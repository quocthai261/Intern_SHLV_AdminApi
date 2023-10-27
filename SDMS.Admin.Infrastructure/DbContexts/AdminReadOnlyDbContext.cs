using MediatR;
using Microsoft.EntityFrameworkCore;
using PB22.Core.MultiTenant;

namespace SDMS.Admin.Infrastructure.DbContexts
{
    public class AdminReadOnlyDbContext : AdminDbContext
    {
        public AdminReadOnlyDbContext(DbContextOptions<AdminReadOnlyDbContext> options, TenantInfo tenantInfo,
            IMediator mediator) : base(options, tenantInfo, mediator)
        {
        }

        public override int SaveChanges()
        {
            throw new InvalidOperationException("Invalid Operation: Current DbContext is read-only");
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            throw new InvalidOperationException("Invalid Operation: Current DbContext is read-only");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            throw new InvalidOperationException("Invalid Operation: Current DbContext is read-only");
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = new())
        {
            throw new InvalidOperationException("Invalid Operation: Current DbContext is read-only");
        }
    }
}