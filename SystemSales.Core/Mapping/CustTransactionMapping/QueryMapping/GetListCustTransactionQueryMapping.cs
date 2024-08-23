using SystemSales.Core.Feature.Transactions.Results;
using SystemSales.Data.Entities;

namespace SystemSales.Core.Mapping.CustTransactionMapping
{
    public partial class CustTransactionsProfile
    {
        public void GetListCustTransactionQueryMapping()
        {
            CreateMap<CustomerTransactions, GetListCustTransactionDTO>();
        }
    }
}
