using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Customers.Results;

namespace SystemSales.Core.Feature.Customers.Queries.Models
{
    public class GetCustomerQuery : IRequest<Response<IEnumerable<GetCustomerQueryDTO>>>
    {
        public string item { get; set; }
        public GetCustomerQuery(string item)
        {
            this.item = item;
        }
    }
}
