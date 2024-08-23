using Microsoft.EntityFrameworkCore;
using SystemSales.Data.Entities;
using SystemSales.infrastructure.Abstracts;
using SystemSales.infrastructure.Context;
using SystemSales.infrastructure.infrastructure;

namespace SystemSales.infrastructure.Repositories
{
    public class CustTransactionsRepository : GenericRepositoryAsync<CustomerTransactions>, ICustTransactionsRepository
    {
        #region Fieleds
        private readonly DbSet<CustomerTransactions> _transaction;
        #endregion

        #region Constructor
        public CustTransactionsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _transaction = dbContext.Set<CustomerTransactions>();
        }
        #endregion
        #region Handels Function


        public async Task<CustomerTransactions> GetCustomerDetailsAsync(string customerCode)
        {
            var customer = await _transaction
         .Where(c => c.Customer_Code == customerCode)
         .OrderByDescending(c => c.record_Date)  // ترتيب العمليات بناءً على تاريخ العملية
         .FirstOrDefaultAsync();

            return customer;
        }
        #endregion
    }
}
