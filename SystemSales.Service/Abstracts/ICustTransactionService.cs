using SystemSales.Data.Entities;

namespace SystemSales.Service.Abstracts
{
    public interface ICustTransactionService
    {
        public Task AddTransactionAsync(CustomerTransactions transaction);
        public Task<List<CustomerTransactions>> GetListsAsync();
        public Task<CustomerTransactions> GetCustomerDetailsAsync(string customerCode);
        Task<List<CustomerTransactions>> SearchAsync(string item);

    }
}
