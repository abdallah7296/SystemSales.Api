using Microsoft.EntityFrameworkCore;
using SystemSales.Data.Entities;
using SystemSales.infrastructure.Abstracts;
using SystemSales.Service.Abstracts;

namespace SystemSales.Service.Services
{
    public class CustomerService : ICustomerService
    {
        #region fields
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustTransactionsRepository _transactionsRepository;
        #endregion

        #region Constructor
        public CustomerService(ICustomerRepository customerRepository, ICustTransactionsRepository transactionsRepository)
        {
            _customerRepository = customerRepository;
            _transactionsRepository = transactionsRepository;
        }
        #endregion

        #region Hndel Functions

        public async Task<string> AddAsync(Customer customer)
        {
            var customerResult = await _customerRepository.GetTableNoTracking().Where(s => s.CustomerName == customer.CustomerName).FirstOrDefaultAsync();
            if (customerResult != null) return "Exist";

            string prefix = "Cust";
            // Define a lambda function to select the property name
            Func<Customer, string> codePropertySelector = entity => nameof(entity.CustomerCode);
            var result = await _customerRepository.AddWithCodeAsync<int>(customer, prefix, codePropertySelector);

            return "Success";
        }

        public async Task<string> GenerateCodeAsync()
        {
            var transaction = new CustomerTransactions
            {
                voucher_Code = await _customerRepository.GenerateCodeAsync<CustomerTransactions>("Trans"),
            };

            return transaction.voucher_Code;
        }

        public async Task<List<Customer>> SearchAsync(string item)
        {
            var customer = await _customerRepository.SearchAsync(item).ToListAsync();
            return customer;
        }
        public async Task<Customer> GetByCode(string Code)
        {
            var customer = await _customerRepository.GetTableAsTracking().Include(x => x.Transactions)
                            .FirstOrDefaultAsync(x => x.CustomerCode == Code);

            return customer;
        }

        public async Task<string> DeleteAsync(Customer customer)
        {
            var trans = _customerRepository.BeginTransaction();
            try
            {
                if (customer.Transactions.Any(t => t.voucher_Debit > 0 || t.voucher_Credit > 0))
                { return "BadRequest"; }
                foreach (var transaction in customer.Transactions)
                {
                    await _transactionsRepository.DeleteAsync(transaction);
                }
                await _customerRepository.DeleteAsync(customer);
                await trans.CommitAsync();
                return "deleted";
            }
            catch
            {
                await trans.RollbackAsync();
                return "field";
            }
        }

        #endregion

    }
}
