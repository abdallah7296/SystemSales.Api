using SystemSales.Core.Feature.Customers.Results;
using SystemSales.Data.Entities;

namespace SystemSales.Core.Mapping.CustomersMapping
{
    public partial class CustomerProfile
    {
        public void GetSingleCustomerMapping()
        {
            CreateMap<Customer, GetSingleCustomerDTO>();
        }

    }
}