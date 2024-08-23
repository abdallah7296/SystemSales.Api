using SystemSales.Core.Feature.Customers.Commands.Request;
using SystemSales.Data.Entities;

namespace SystemSales.Core.Mapping.CustomersMapping
{
    public partial class CustomerProfile
    {
        public void AddCustomerCommandMapping()
        {
            CreateMap<CreateCustomerRequest, Customer>()
            .ForMember(dest => dest.Transactions, opt => opt.Ignore());

            CreateMap<CreateCustomerRequest, CustomerTransactions>()
                .ForMember(dest => dest.voucher_Credit, opt => opt.MapFrom(src => src.VoucherCredit))
                .ForMember(dest => dest.voucher_Debit, opt => opt.MapFrom(src => src.VoucherDebit));
        }

    }
}
