using SystemSales.Core.Feature.Customers.Results;
using SystemSales.Data.Entities;

namespace SystemSales.Core.Mapping.CustomersMapping
{
    public partial class CustomerProfile
    {
        public void GetCustomerQueryMapping()
        {
            CreateMap<Customer, GetCustomerQueryDTO>()
            .ForMember(dest => dest.voucher_Debit, opt => opt.MapFrom(src =>
                     src.Transactions.OrderByDescending(t => t.record_Date)
                    .Select(t => t.voucher_Debit)
                    .FirstOrDefault()));


        }

    }
}
