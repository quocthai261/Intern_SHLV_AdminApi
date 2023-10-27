using SDMS.Admin.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore.Infrastructure.Internal;
using PB22.Core.Database;
using PB22.Core.MultiTenant;

namespace SDMS.Admin.Infrastructure.DbContexts;

public partial class AdminDbContext : CoreDbContext
{
    private static string ConnectionStringUserId = "";

    public AdminDbContext(DbContextOptions<AdminDbContext> options, TenantInfo tenantInfo, IMediator mediator) : base(
        options, tenantInfo, mediator)
    {
        InitSchema(options);
    }

    protected AdminDbContext(DbContextOptions options, TenantInfo tenantInfo, IMediator mediator) : base(options,
        tenantInfo, mediator)
    {
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        if (!string.IsNullOrWhiteSpace(ConnectionStringUserId)) modelBuilder.HasDefaultSchema(ConnectionStringUserId);
    }

    private void InitSchema(DbContextOptions<AdminDbContext> options)
    {
        if (string.IsNullOrEmpty(ConnectionStringUserId))
            foreach (var option in options.Extensions)
            {
                if (option is OracleOptionsExtension oracleOption &&
                    !string.IsNullOrWhiteSpace(oracleOption.ConnectionString))
                {
                    var keyValues = oracleOption.ConnectionString.Split(";", StringSplitOptions.TrimEntries);
                    foreach (var keyValue in keyValues)
                    {
                        var key = keyValue.Split("=")[0];
                        var value = keyValue.Split("=")[1];
                        if (key.Equals("User Id", StringComparison.OrdinalIgnoreCase))
                        {
                            ConnectionStringUserId = value.Trim();
                            return;
                        }
                    }
                }
            }
    }
}