using System.Reflection;
using Asp.Versioning;
using Autofac;
using FluentValidation.AspNetCore;
using Mapster;
using MapsterMapper;
using MassTransit;
using MediatR;
using Microsoft.OpenApi.Models;
using PB22.Core.Api.Extensions;
using PB22.Core.Api.Middlewares;
using PB22.Core.Api.Misc;
using PB22.Core.Infrastructure;
using PB22.Core.Infrastructure.QueryServices;
using PB22.Core.MessageBus;
using PB22.Core.MultiTenant;
using PB22.Core.Outbox.Abstractions;
using SDMS.Admin.Api.Factories;
using SDMS.Admin.Infrastructure;
using SDMS.Admin.Infrastructure.DbContexts;
using PB22.Extensions.Localization.Json;
using PB22.Extend.Api.Extensions;
using PB22.Extend.Authentication;
using PB22.Extensions.Minio.Operations;
using PB22.Extensions.Minio;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Minio;
using SDMS.Admin.Domain.Entities;
using PB22.Extend.Api.Features;
using SDMS.Admin.App.Commands;
using SDMS.Admin.App.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using SDMS.Admin.App.Dtos.SysMenus;
using SDMS.Admin.Api.Dtos.CatProvince;
using SDMS.Admin.App.Dtos.CatDistrict;
using SDMS.Admin.App.Dtos.CatWard;
using SDMS.Admin.App.Dtos.CatGender;
using SDMS.Admin.App.Dtos.CatBank;
using SDMS.Admin.App.Dtos.CatBankBranch;
using SDMS.Admin.App.Dtos.CatCustomerType;
using SDMS.Admin.App.Dtos.CatRelation;
using SDMS.Admin.App.Dtos.SyncJob;
using SDMS.Admin.App.Dtos.SysApplication;
using SDMS.Admin.App.Dtos.SysLanguage;
using SDMS.Admin.App.Dtos.SysLocaleMessage;
using SDMS.Admin.App.Dtos.SysMobileMenu;
using SDMS.Admin.App.Dtos.SysUserLoginHistory;
using SDMS.Admin.App.Dtos.SysSetting;
using SDMS.Admin.App.Dtos.SysRole;
using SDMS.Admin.App.Dtos.SysPermission;
using SDMS.Admin.App.Dtos.CatNationality;
using SDMS.Admin.App.QueryExpressions;
using SDMS.Admin.App.Services;
//#if !DEBUG
//using FIS.Agency.Api.Middlewares;
//#endif

namespace SDMS.Admin.Api
{
    public class Startup
    {
        #region Fields

        private readonly IConfiguration _configuration;

        #endregion

        #region Constructors

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #endregion

        #region Methods

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiVersioning(o =>
            {
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
                o.ReportApiVersions = true;
                // o.ApiVersionReader = ApiVersionReader.Combine(
                //     new HeaderApiVersionReader("X-Version")
                // );
            });

            services
                .AddHttpClient()
                .AddHttpContextAccessor()
                .AddHealthChecks()
                .AddDbContextCheck<AdminReadOnlyDbContext>();

#if DEBUG
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ADMIN API", Version = "v1" });
            });
#endif

            services.AddCors(c => { c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin()); });

            services.AddScoped<TenantInfo>();

            services.AddLocalization(_configuration);

            services.AddKebabNamingControllers()
                .AddFluentValidation(fv =>
                {
                    Assembly[] types = { typeof(BaseValidator<>).Assembly, typeof(Startup).Assembly };
                    fv.RegisterValidatorsFromAssemblies(types);
                    fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                    fv.ImplicitlyValidateChildProperties = true;
                });

            services
                .AddMediatR(typeof(Startup), typeof(DummyCommand), typeof(DummyFeatureHandler))
                .AddMemoryCache();

            services.AddScoped<IEventLogServiceProvider, SqlEventLogServiceProvider>();

            RegisterDatabase(services);

            var rbmqConnString = _configuration["RabbitMQConfig"];
            services.AddMassTransit(x =>
            {
                x.SetKebabCaseEndpointNameFormatter();
                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(rbmqConnString);

                    cfg.UseConsumeFilter(typeof(TenantFilter<>), context);
                    cfg.UseSendFilter(typeof(TenantFilter<>), context);
                    cfg.UsePublishFilter(typeof(TenantFilter<>), context);

                    cfg.ConfigureEndpoints(context);
                });
            });

            /**/
            services.AddAuthentication(_configuration);
            services.AddBaseHandler();
            services.AddStorage(_configuration);

        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(AdminDbContext).Assembly, typeof(IDummyService).Assembly)
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(SysMenusExpression).Assembly, typeof(IMapper).Assembly)
                .AsImplementedInterfaces();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
       
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseRequestLocalization();

            app.UseHttpsRedirection();
            app.UseRouting();

#if DEBUG
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ADMIN API V1");
                c.RoutePrefix = "doc";
            });
#endif

            app.UseCors(cors => cors.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            SetMiddlewares(app);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/healthz");
                endpoints.MapDefaultControllerRoute();
            });
        }
        private void RegisterDatabase(IServiceCollection services)
        {
            var dbConfig = new DbConnectionStringOption();
            _configuration.GetSection("ConnectionStrings").Bind(dbConfig);
            services
                .AddDataAccessLayer<AdminDbContext, AdminReadOnlyDbContext>(dbConfig)
                .AddIntegrationServices(typeof(AdminDbContext));

            services.AddScoped<IQueryService>(provider =>
                new QueryService(provider.GetService<AdminReadOnlyDbContext>(), provider.GetService<IMapper>()));
            services.AddScoped<IWriteableQueryService>(provider =>
                new WriteableQueryService(provider.GetService<AdminDbContext>(), provider.GetService<IMapper>()));
        }

        private void SetMiddlewares(IApplicationBuilder app)
        {
            app.UseGlobalErrorHandlerMiddleware();
            //app.UseMultiLanguageMiddleware();
        }

        #endregion
    }

    public static class ConfigureServicesExtensions
    {
        public static void AddAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtBearerSettings = configuration.GetSection("OAuth").Get<JwtBearerSettings>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = jwtBearerSettings.Authority;
                    options.RequireHttpsMetadata = jwtBearerSettings.RequireHttpsMetadata;

                    if (string.IsNullOrEmpty(jwtBearerSettings.Audience))
                    {
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateAudience = false
                        };
                    }
                    else
                    {
                        options.Audience = jwtBearerSettings.Audience;
                    }
                });

            //services.AddAuthorization(options =>
            //{
            //    options.FallbackPolicy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //});
        }

        public static void AddBaseHandler(this IServiceCollection services)
        {
            // 
            services.AddBaseControllerRepositories<AdminReadOnlyDbContext, AdminDbContext>();

            // base controller handlers (include base mapping)
            services.AddBaseControllerHandlers<SysMenu, QuerySysMenusDto, CreateSysMenusDto, UpdateSysMenusDto>();
            services.AddBaseControllerHandlers<CatProvince, QueryCatProvinceDto, CreateCatProvinceDto, UpdateCatProvinceDto>();
            services.AddBaseControllerHandlers<CatNationality, QueryCatNationalityDto, CreateCatNationalityDto, UpdateCatNationalityDto>();
            services.AddBaseControllerHandlers<CatDistrict, QueryCatDistrictDto, CreateCatDistrictDto, UpdateCatDistrictDto>();
            services.AddBaseControllerHandlers<CatWard, QueryCatWardDto, CreateCatWardDto, UpdateCatWardDto>();
            services.AddBaseControllerHandlers<CatGender, QueryCatGenderDto, CreateCatGenderDto, UpdateCatGenderDto>();
            services.AddBaseControllerHandlers<CatBank, QueryCatBankDto, CreateCatBankDto, UpdateCatBankDto>();
            services.AddBaseControllerHandlers<CatBankBranch, QueryCatBankBranchDto, CreateCatBankBranchDto, UpdateCatBankBranchDto>();
            services.AddBaseControllerHandlers<CatCustomerType, QueryCatCustomerTypeDto, CreateCatCustomerTypeDto, UpdateCatCustomerTypeDto>();
            services.AddBaseControllerHandlers<CatRelation, QueryCatRelationDto, CreateCatRelationDto, UpdateCatRelationDto>();

            services.AddBaseControllerHandlers < SyncJob, QuerySyncJobDto, CreateSyncJobDto, UpdateSyncJobDto > ();
            services.AddBaseControllerHandlers < SysApplication, QuerySysApplicationDto, CreateSysApplicationDto, UpdateSysApplicationDto > ();
            services.AddBaseControllerHandlers < SysLanguage, QuerySysLanguageDto, CreateSysLanguageDto, UpdateSysLanguageDto > ();
            services.AddBaseControllerHandlers < SysLocaleMessage, QuerySysLocaleMessageDto, CreateSysLocaleMessageDto, UpdateSysLocaleMessageDto > ();
            services.AddBaseControllerHandlers < SysMenu, QuerySysMenusDto, CreateSysMenusDto, UpdateSysMenusDto > ();
            services.AddBaseControllerHandlers < SysMobileMenu, QuerySysMobileMenuDto, CreateSysMobileMenuDto, UpdateSysMobileMenuDto > ();
            services.AddBaseControllerHandlers < SysPermission, QuerySysPermissionDto, CreateSysPermissionDto, UpdateSysPermissionDto > ();
            services.AddBaseControllerHandlers < SysRole, QuerySysRoleDto, CreateSysRoleDto, UpdateSysRoleDto > ();
            services.AddBaseControllerHandlers < SysSetting, QuerySysSettingDto, CreateSysSettingDto, UpdateSysSettingDto > ();
            services.AddBaseControllerHandlers < SysUserLoginHistory, QuerySysUserLoginHistoryDto, CreateSysUserLoginHistoryDto, UpdateSysUserLoginHistoryDto > ();

        }

        public static void AddStorage(this IServiceCollection services, IConfiguration configuration)
        {
            var minioOptions = configuration.GetSection("FileServer:MinioOptions").Get<MinioOptions>();

            services.Configure<MinioOptions>(options =>
            {
                options.Endpoint = minioOptions.Endpoint;
                options.AccessKey = minioOptions.AccessKey;
                options.SecretKey = minioOptions.SecretKey;
                options.Region = minioOptions.Region;
                options.SessionToken = minioOptions.SessionToken;
                options.Ssl = minioOptions.Ssl;
            });

            services.AddMinio();

            var defaultBucketName = configuration["FileServer:DefaultBucketName"];
            services.AddScoped<IMinioObjectOperations>(provider =>
                new MinioObjectOperations(provider.GetService<ILogger>(), provider.GetService<IMinioClient>(), defaultBucketName));
        }
    }
}