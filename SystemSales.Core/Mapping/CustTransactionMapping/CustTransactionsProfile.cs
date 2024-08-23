using AutoMapper;

namespace SystemSales.Core.Mapping.CustTransactionMapping
{
    public partial class CustTransactionsProfile : Profile
    {
        public CustTransactionsProfile()
        {
            GetCustTransactionQuery();
            AddTransactionCommandMapping();
            GetListCustTransactionQueryMapping();
        }
    }
}
