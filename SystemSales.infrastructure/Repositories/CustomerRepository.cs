using Microsoft.EntityFrameworkCore;
using SystemSales.Data.Entities;
using SystemSales.infrastructure.Abstracts;
using SystemSales.infrastructure.Context;
using SystemSales.infrastructure.infrastructure;

namespace SystemSales.infrastructure.Repositories
{
    public class CustomerRepository : GenericRepositoryAsync<Customer>, ICustomerRepository
    {
        #region Fieleds
        private readonly DbSet<Customer> _customers;
        #endregion

        #region Constructor
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _customers = dbContext.Set<Customer>();
        }
        #endregion
        #region Handels Function
        public IQueryable<Customer> SearchAsync(string item)
        {
            return _customers.AsNoTracking()
                             .Include(t => t.Transactions)
                             .Where(x => x.CustomerName.Contains(item) || x.CustomerCode.Contains(item));
        }
        #endregion
    }
}
