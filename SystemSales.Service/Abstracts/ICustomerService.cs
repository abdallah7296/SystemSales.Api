using SystemSales.Data.Entities;

namespace SystemSales.Service.Abstracts
{
    public interface ICustomerService
    {
        public Task<string> AddAsync(Customer customer);
        public Task<List<Customer>> SearchAsync(string item);
        public Task<string> GenerateCodeAsync();
        public Task<Customer> GetByCode(string Code);
        public Task<string> DeleteAsync(Customer customer);
    }
}
