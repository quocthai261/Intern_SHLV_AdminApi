using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using PB22.Core.Database;
using PB22.Core.Infrastructure;
using PB22.Core.Outbox.Services;

namespace SDMS.Admin.Infrastructure;

public static class ServicesConfigurator
{
    #region Fields

    private static readonly LoggerFactory LoggerFactory = new(new[] { new DebugLoggerProvider() });

    #endregion

    #region Methods

    public static IServiceCollection AddDataAccessLayer<TContext, TReadOnlyContext>(
        this IServiceCollection services, DbConnectionStringOption connectionStrings)
        where TContext : DbContext, IUnitOfWork where TReadOnlyContext : TContext
    {
        services.AddDbContext<TContext>(builder =>
            builder
#if DEBUG
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
                .UseLoggerFactory(LoggerFactory)
#endif
                .UseLazyLoadingProxies()
                .UseOracle(connectionStrings.Write, options => options.UseOracleSQLCompatibility("11"))
        );

        services.AddDbContext<TReadOnlyContext>(builder =>
            builder
#if DEBUG
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
                .UseLoggerFactory(LoggerFactory)
#endif
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .UseOracle(connectionStrings.Reads.First(), options => options.UseOracleSQLCompatibility("11"))
        );

        services
            .AddScoped<IUnitOfWork, TContext>()
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehaviour<,>));

        return services;
    }

    public static IServiceCollection AddIntegrationServices(this IServiceCollection services, Type dbContextType)
    {
        services
            .AddTransient<IIntegrationEventService, IntegrationEventService>()
            .AddScoped(x => (CoreDbContext)x.GetService(dbContextType));

        return services;
    }

    #endregion
}