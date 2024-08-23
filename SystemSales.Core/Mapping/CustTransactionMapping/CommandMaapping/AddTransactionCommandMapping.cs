using SystemSales.Core.Feature.Transactions.Commands.Models;
using SystemSales.Data.Entities;

namespace SystemSales.Core.Mapping.CustTransactionMapping
{
    public partial class CustTransactionsProfile
    {
        public void AddTransactionCommandMapping()
        {
            CreateMap<CreateTransactionCommand, CustomerTransactions>()
            .ForMember(dest => dest.voucher_Debit, opt => opt.MapFrom(src => src.voucher_Debit))
            .ForMember(dest => dest.voucher_Credit, opt => opt.MapFrom(src => src.voucher_Credit))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
