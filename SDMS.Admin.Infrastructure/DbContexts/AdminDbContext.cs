using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Infrastructure.DbContexts;

public partial class AdminDbContext
{

    public AdminDbContext(DbContextOptions<AdminDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.HasDefaultSchema("SDMS");
        modelBuilder.Entity<SysRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysRolesPk");
            entity.ToTable("SysRoles");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.ConCurrencyStamp).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .IsUnicode(false)
                .IsRequired();
            entity.Property(e => e.IsSystem).HasPrecision(1).IsRequired();
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
        });
        modelBuilder.Entity<SysPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysPermissionsPk");
            entity.ToTable("SysPermissions");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.PermissionName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Type).HasPrecision(10);
            entity.Property(e => e.Application)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentId).HasPrecision(19);
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.IsPermisstion).HasPrecision(1);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
        });
        modelBuilder.Entity<SysSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysSettingsPk");
            entity.ToTable("SysSettings");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.GroupSetting).HasMaxLength(50);
            entity.Property(e => e.SettingCode).HasMaxLength(50);
            entity.Property(e => e.SettingName).HasMaxLength(100);
            entity.Property(e => e.SettingValue).HasMaxLength(100);
            entity.Property(e => e.SettingDesciption).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasPrecision(1).IsRequired();
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
        });
        modelBuilder.Entity<SysMobileMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysMobileMenusPk");
            entity.ToTable("SysMobileMenus");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.Code).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.IsActive).HasPrecision(1).HasDefaultValueSql("1");
            entity.Property(e => e.IsDefault).HasPrecision(1).HasDefaultValueSql("1");
            entity.Property(e => e.Order_).HasPrecision(19).HasDefaultValueSql("0");
            entity.Property(e => e.Icon1).HasMaxLength(256);
            entity.Property(e => e.Icon2).HasMaxLength(50);
            entity.Property(e => e.Color1).HasMaxLength(8).IsUnicode(false);
            entity.Property(e => e.Color2).HasMaxLength(8).IsUnicode(false);
            entity.Property(e => e.Color3).HasMaxLength(8).IsUnicode(false);
            entity.Property(e => e.ParentId).HasMaxLength(200).IsUnicode(false);
            entity.Property(e => e.PermissionName).HasMaxLength(500);

            entity.Property(e => e.IsFavoriteDefault).HasPrecision(1).HasDefaultValueSql("0"); ;
            entity.Property(e => e.FavoriteIndex).HasPrecision(8);
            entity.Property(e => e.IsInstantPush).HasPrecision(1).HasDefaultValueSql("0").IsRequired();
            entity.Property(e => e.SetInstantPush).HasPrecision(1).HasDefaultValueSql("0").IsRequired();
            entity.Property(e => e.InstantPushId).HasPrecision(19);

            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
        });
        modelBuilder.Entity<SysLocaleMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysLocaleMessagesPk");
            entity.ToTable("SysLocaleMessages");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.LanguageId).HasPrecision(19).IsRequired();
            entity.Property(e => e.MessageName).HasMaxLength(200).IsRequired().IsUnicode(false);
            entity.Property(e => e.MessageValue).HasMaxLength(500).IsRequired();
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
        });
        modelBuilder.Entity<SysApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysApplicationPk");
            entity.ToTable("SysApplication");

            entity.Property(e => e.Id).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.SysApplicationName).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Index).HasPrecision(8);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
        });
        modelBuilder.Entity<SyncJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SyncJobsPk");
            entity.ToTable("SyncJobs");
            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.ScheduleTypeId).HasPrecision(19).IsRequired();
            entity.Property(e => e.ScheduleDescription).HasMaxLength(1024);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.LastRun).HasColumnType("DATE");
            entity.Property(e => e.NextRun).HasColumnType("DATE");
            entity.Property(e => e.Enable).HasPrecision(1).HasDefaultValueSql("1");
            entity.Property(e => e.Valid).HasPrecision(1).HasDefaultValueSql("1");
            entity.Property(e => e.JobIsRunning).HasPrecision(1);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.ComplexPriority).HasPrecision(2);
            entity.Property(e => e.ForceRun).HasPrecision(1).HasDefaultValueSql("0");


        });
        modelBuilder.Entity<SysActivityLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysActivityLogsPk");
            entity.ToTable("SysActivityLogs");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50).IsRequired();
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.Client).HasMaxLength(300);
            entity.Property(e => e.Host).HasMaxLength(50);
            entity.Property(e => e.Time).HasColumnType("DATE").IsRequired();
            entity.Property(e => e.CustomData).HasMaxLength(2000);
            entity.Property(e => e.State).HasPrecision(1);
            entity.Property(e => e.Action).HasMaxLength(2000);
            entity.Property(e => e.Duration).HasPrecision(19);
            entity.Property(e => e.Source).HasMaxLength(30);
            entity.Property(e => e.Device).HasMaxLength(30);
            entity.Property(e => e.Brand).HasMaxLength(30);
            entity.Property(e => e.Model).HasMaxLength(30);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.Os).HasMaxLength(30);
            entity.Property(e => e.Provider).HasMaxLength(50);
            entity.Property(e => e.Parameters).HasColumnType("CLOB");
        });
        modelBuilder.Entity<SysLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysLanguagePk");
            entity.ToTable("SysLanguage");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
            entity.Property(e => e.LanguageCulture).HasMaxLength(20).IsRequired();
            entity.Property(e => e.FlagImageFileName).HasMaxLength(50);
            entity.Property(e => e.DisplayOrder).HasPrecision(3);
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
        });
        modelBuilder.Entity<SysUserLoginHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysUserLoginHistoriesPk");
            entity.ToTable("SysUserLoginHistories");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.LoginDate).HasColumnType("DATE");
            entity.Property(e => e.Browser).HasMaxLength(256);
            entity.Property(e => e.Device).HasMaxLength(50);
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.Status).HasPrecision(1);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
        });
        modelBuilder.HasSequence("SeqSysRoles");
        modelBuilder.HasSequence("SeqSysPermissions");
        modelBuilder.HasSequence("SeqSysMobileMenus");
        modelBuilder.HasSequence("SeqSysSettings");
        modelBuilder.HasSequence("SeqSysLocaleMessages");
        modelBuilder.HasSequence("SeqSysApplication");
        modelBuilder.HasSequence("SeqSyncJobs");
        modelBuilder.HasSequence("SeqSysActivityLogs");
        modelBuilder.HasSequence("SeqSysLanguague");
        modelBuilder.HasSequence("SeqSysUserLoginHistories");
        modelBuilder.Entity<CatProvince>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CatProvincePk");

            entity.ToTable("CatProvinces");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.ProvinceCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });


        modelBuilder.Entity<CatNationality>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatNationalities");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.NationalityCode).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.NationalityName).HasMaxLength(50).IsUnicode(true);
        });

        modelBuilder.HasSequence("SeqCatNationalities");

        modelBuilder.Entity<CatDistrict>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatDistricts");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.DistrictCode).HasMaxLength(20).IsUnicode(true);
            entity.Property(e => e.DistrictName).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.ProvinceCode).HasPrecision(19);
            entity.Property(e => e.RegionId).HasPrecision(19);
        });
        modelBuilder.HasSequence("SeqCatDistricts");

        modelBuilder.Entity<CatWard>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatWards");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.DistrictCode).HasPrecision(19);
            entity.Property(e => e.WardCode).HasMaxLength(20).IsUnicode(true);
            entity.Property(e => e.WardName).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.SalaryPeriodType).HasMaxLength(50).IsUnicode(true);
        });

        modelBuilder.HasSequence("SeqCatWards");

        modelBuilder.Entity<CatGender>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatGenders");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.GenderCode).HasMaxLength(1).IsUnicode(false);
            entity.Property(e => e.GenderNameEng).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.GenderNameVie).HasMaxLength(50).IsUnicode(false);
        });

        modelBuilder.HasSequence("SeqCatGender");

        modelBuilder.Entity<CatBank>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatBanks");

            entity.Property(e => e.Id).HasPrecision(12);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.IdType).HasPrecision(2);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.BankOrgCode).HasMaxLength(50).IsUnicode(false).IsRequired();
            entity.Property(e => e.BankOrgName).HasMaxLength(100).IsUnicode(false).IsRequired();
            entity.Property(e => e.AbbrName).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.IdNumber).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Status).HasMaxLength(1).IsUnicode(false);
        });

        modelBuilder.HasSequence("SeqCatBanks");

        modelBuilder.Entity<CatBankBranch>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatBankBranchs");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.AddressId).HasPrecision(19);
            entity.Property(e => e.BankId).HasPrecision(12);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IdType).HasPrecision(2);
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");

            entity.Property(e => e.BranchCode).HasMaxLength(20).IsUnicode(false).IsRequired();
            entity.Property(e => e.BranchName).HasMaxLength(100).IsUnicode(false).IsRequired();
            entity.Property(e => e.AbbrName).HasMaxLength(100).IsUnicode(false).IsRequired();
            entity.Property(e => e.BranchClass).HasMaxLength(1).IsUnicode(false).IsRequired();
            entity.Property(e => e.Status).HasMaxLength(1).IsUnicode(false).IsRequired();
            entity.Property(e => e.BranchType).HasMaxLength(2).IsUnicode(false).IsRequired();
            entity.Property(e => e.InternalCode).HasMaxLength(20).IsUnicode(false);
            entity.Property(e => e.IdNumber).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Address1).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Address2).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Address3).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Address4).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Address5).HasMaxLength(100).IsUnicode(false);
        });

        modelBuilder.HasSequence("SeqCatBankBranchs");

        modelBuilder.Entity<CatCustomerType>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatCustomerTypes");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.CustomerTypeCode).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.CustomerTypeName).HasMaxLength(100).IsUnicode(true);
        });

        modelBuilder.HasSequence("SeqCatCustomerType");

        modelBuilder.Entity<CatRelation>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("CatRelations");

            entity.Property(e => e.Id).HasPrecision(19);
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.IsActive).HasPrecision(1);
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);

            entity.Property(e => e.RelationCode).HasMaxLength(20).IsUnicode(true);
            entity.Property(e => e.RelationNameEng).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.RelationNameVie).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.RelationGroup).HasMaxLength(100).IsUnicode(false);

            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
        });

        modelBuilder.HasSequence("SeqCatRelations");

        modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("SysMenusPk");

                entity.ToTable("SysMenus");

                entity.Property(e => e.Id).HasPrecision(19);
                entity.Property(e => e.AppId).HasPrecision(19);
                entity.Property(e => e.Code).HasMaxLength(50);
                entity.Property(e => e.Color1)
                    .HasMaxLength(8)
                    .IsUnicode(false);
                entity.Property(e => e.Color2)
                    .HasMaxLength(8)
                    .IsUnicode(false);
                entity.Property(e => e.Color3)
                    .HasMaxLength(8)
                    .IsUnicode(false);
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(256);
                entity.Property(e => e.CreatedBy).HasPrecision(19);
                entity.Property(e => e.CreationDate).HasColumnType("DATE");
                entity.Property(e => e.Icon1).HasMaxLength(256);
                entity.Property(e => e.Icon2).HasMaxLength(256);
                entity.Property(e => e.IconClass).HasMaxLength(100);
                entity.Property(e => e.IsActive).HasPrecision(1);
                entity.Property(e => e.IsDefault)
                    .HasPrecision(1)
                    .HasDefaultValueSql("0");
                entity.Property(e => e.IsDisplay).HasPrecision(1);
                entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
                entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
                entity.Property(e => e.Order).HasPrecision(19);
                entity.Property(e => e.ParentCode).HasMaxLength(50);
                entity.Property(e => e.PermissionName).HasMaxLength(500);
                entity.Property(e => e.SourceType).HasPrecision(10);
                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(300);
            });

        //pdk-

        modelBuilder.Entity<SysUserInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysUserInformationsPk");
            entity.ToTable("SysUserInformations");

            entity.Property(e => e.Id).HasPrecision(19).IsRequired();
            entity.Property(e => e.UserId).HasPrecision(19).IsRequired();
            entity.Property(e => e.IdentificationNumber).HasPrecision(19).IsRequired();
            entity.Property(e => e.Gender).HasMaxLength(1);
            entity.Property(e => e.DayOfBirth).HasColumnType("DATE");
            entity.Property(e => e.Address).HasMaxLength(256);
            entity.Property(e => e.Status).HasPrecision(2);
            entity.Property(e => e.JoiningDate).HasColumnType("DATE");
            entity.Property(e => e.ResignationDate).HasColumnType("DATE");
            entity.Property(e => e.Degree).HasMaxLength(50);
            entity.Property(e => e.Major).HasMaxLength(50);
            entity.Property(e => e.DegreeClassification).HasMaxLength(15);
            entity.Property(e => e.ImageIdentificationFront).HasMaxLength(256);
            entity.Property(e => e.ImageIdentificationBack).HasMaxLength(256);
            entity.Property(e => e.ImageDegree).HasMaxLength(256);
            entity.Property(e => e.ImageHealthCertification).HasMaxLength(256);
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
        });
        modelBuilder.Entity<SysUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SysUsersPk");
            entity.ToTable("SysUsers");

            entity.Property(e => e.Id).HasPrecision(19).IsRequired();
            entity.Property(e => e.ReferentId).HasMaxLength(64).IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(256).IsRequired();
            entity.Property(e => e.UserType).HasPrecision(2).IsRequired();
            entity.Property(e => e.UserRule).HasPrecision(2).IsRequired();
            entity.Property(e => e.Provider).HasMaxLength(16);  
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SurName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(16);
            entity.Property(e => e.LastLogin).HasColumnType("DATE");
            entity.Property(e => e.CreationDate).HasColumnType("DATE");
            entity.Property(e => e.CreatedBy).HasPrecision(19);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("DATE");
            entity.Property(e => e.LastUpdatedBy).HasPrecision(19);
        });

        modelBuilder.HasSequence("SeqSysUsers");

        modelBuilder.HasSequence("SeqSysUserInformations");

        //pdk-end

        modelBuilder.HasSequence("SeqCatProvince");
        modelBuilder.HasSequence("SeqSysMenus");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
