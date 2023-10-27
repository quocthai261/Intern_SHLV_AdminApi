using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PB22.Core.Database;
using PB22.Core.Outbox;
using PB22.Core.Outbox.Abstractions;
using PB22.Core.Outbox.Services;

namespace SDMS.Admin.Api.Factories
{
    public class SqlEventLogServiceProvider : IEventLogServiceProvider
    {
        private readonly DbContext _context;

        public SqlEventLogServiceProvider(CoreDbContext context)
        {
            _context = context;
        }

        public IIntegrationEventLogService CreateService()
        {
            return new SqlIntegrationEventLogService(_context.Database.GetDbConnection());
        }

        public IEventLogTransaction GetCurrentTransaction()
        {
            var transaction = _context.Database.CurrentTransaction;

            return new EventLogTransaction
            {
                TransactionId = transaction.TransactionId,
                Transaction = (transaction as RelationalTransaction).GetDbTransaction()
            };
        }
    }
}