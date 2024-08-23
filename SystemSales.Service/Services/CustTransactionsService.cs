using SystemSales.Data.Entities;
using SystemSales.infrastructure.Abstracts;
using SystemSales.Service.Abstracts;

namespace SystemSales.Service.Services
{
    public class CustTransactionsService : ICustTransactionService
    {

        #region Fields
        private readonly ICustTransactionsRepository _transactionsRepository;
        #endregion
        #region Constructor
        public CustTransactionsService(ICustTransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }
        #endregion
        #region Hndle Method
        public async Task<CustomerTransactions> GetCustomerDetailsAsync(string customerCode)
         => await _transactionsRepository.GetCustomerDetailsAsync(customerCode);
        public async Task AddTransactionAsync(CustomerTransactions transaction)
            => await _transactionsRepository.AddAsync(transaction);

        public async Task<List<CustomerTransactions>> GetListsAsync()
           => await _transactionsRepository.GetListAsync();

        public async Task<List<CustomerTransactions>> SearchAsync(string item)
        {
            var customers = _transactionsRepository
            .Search(x => x.CustomerName.Contains(item) || x.Customer_Code.Contains(item)).ToList();
            return customers;
        }



        #endregion
    }
}
