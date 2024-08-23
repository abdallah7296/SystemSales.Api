using MediatR;
using SystemSales.Core.Base;
using SystemSales.Core.Feature.Customers.Commands.Request;

namespace SystemSales.Core.Feature.Customers.Commands.Models
{
    public class CreateCustomerCommand : IRequest<Response<string>>
    {
        public CreateCustomerRequest Customer { get; set; }

        public CreateCustomerCommand(CreateCustomerRequest customer)
        {
            Customer = customer;
        }
    }
}

