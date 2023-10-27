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

        modelBuilder.HasSequence("SeqCatProvince");
        modelBuilder.HasSequence("SeqSysMenus");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
