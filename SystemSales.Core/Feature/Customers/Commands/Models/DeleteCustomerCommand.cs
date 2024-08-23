using MediatR;
using SystemSales.Core.Base;

namespace SystemSales.Core.Feature.Customers.Commands.Models
{
    public class DeleteCustomerCommand : IRequest<Response<string>>
    {
        public string CustomerCode { get; set; }
        public DeleteCustomerCommand(string Code)
        { CustomerCode = Code; }

    }
}
