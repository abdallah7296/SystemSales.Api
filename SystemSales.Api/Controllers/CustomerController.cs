using Microsoft.AspNetCore.Mvc;
using SystemSales.Api.Base;
using SystemSales.Core.Feature.Customers.Commands.Models;
using SystemSales.Core.Feature.Customers.Commands.Request;
using SystemSales.Core.Feature.Customers.Queries.Models;
using static SystemSales.Data.AppMetaData.Router;

namespace SystemSales.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomerController : AppControllerBase
    {

        [HttpPost(CustomerRoute.Create)]
        public async Task<IActionResult> Create(CreateCustomerRequest request)
        {
            var command = new CreateCustomerCommand(request);
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpGet(CustomerRoute.Search)]
        public async Task<IActionResult> GetCustomers(string item)
        {
            var query = new GetCustomerQuery(item);
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet(CustomerRoute.GetByCode)]
        public async Task<IActionResult> GetByCode(string item)
        {
            var result = await Mediator.Send(new GetCustomerByCodeQuery(item));
            return NewResult(result);
        }
        [HttpDelete(CustomerRoute.Delete)]
        public async Task<IActionResult> DeleteAsync(string item)
        {
            var result = await Mediator.Send(new DeleteCustomerCommand(item));
            return NewResult(result);
        }

    }
}
