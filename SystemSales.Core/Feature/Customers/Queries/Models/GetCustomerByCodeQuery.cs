using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Customers.Results;

namespace SystemSales.Core.Feature.Customers.Queries.Models
{
    public class GetCustomerByCodeQuery : IRequest<Response<GetSingleCustomerDTO>>
    {
        public string Code { get; set; }
        public GetCustomerByCodeQuery(string code)
        { Code = code; }
    }
}
