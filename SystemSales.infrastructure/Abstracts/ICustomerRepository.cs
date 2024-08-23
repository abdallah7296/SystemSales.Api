using SystemSales.Data.Entities;
using SystemSales.infrastructure.infrastructure;

namespace SystemSales.infrastructure.Abstracts
{
    public interface ICustomerRepository : IGenericRepositoryAsync<Customer>
    {
        IQueryable<Customer> SearchAsync(string item);
    }
}
