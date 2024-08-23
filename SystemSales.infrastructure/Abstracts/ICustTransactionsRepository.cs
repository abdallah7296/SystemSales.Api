using SystemSales.Data.Entities;
using SystemSales.infrastructure.infrastructure;

namespace SystemSales.infrastructure.Abstracts
{
    public interface ICustTransactionsRepository : IGenericRepositoryAsync<CustomerTransactions>
    {
        Task<CustomerTransactions> GetCustomerDetailsAsync(string customerCode);
    }
}
