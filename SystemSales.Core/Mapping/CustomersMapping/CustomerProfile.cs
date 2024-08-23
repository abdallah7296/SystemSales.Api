using AutoMapper;

namespace SystemSales.Core.Mapping.CustomersMapping
{
    public partial class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            AddCustomerCommandMapping();
            GetCustomerQueryMapping();
            GetSingleCustomerMapping();
        }

    }
}
