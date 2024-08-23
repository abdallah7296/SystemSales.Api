using Microsoft.AspNetCore.Mvc;
using SystemSales.Api.Base;
using SystemSales.Core.Feature.Transactions.Commands.Models;
using SystemSales.Core.Feature.Transactions.Queries.Models;
using static SystemSales.Data.AppMetaData.Router;

namespace SystemSales.Api.Controllers
{
    [ApiController]
    public class TransactionController : AppControllerBase
    {

        [HttpGet(CustomerTransactionRoute.List)]
        public async Task<IActionResult> GetListAsync()
        {
            var result = await Mediator.Send(new GetListCustTransactionQuery());
            return NewResult(result);
        }

        [HttpGet(CustomerTransactionRoute.GetByCode)]
        public async Task<IActionResult> GetCustomerDetails(string customerCode)
        {
            var result = await Mediator.Send(new GetTransactionByCodeQuery(customerCode));
            return NewResult(result);
        }

        [HttpPost(CustomerTransactionRoute.Create)]
        public async Task<IActionResult> CreateTransaction([FromBody] CreateTransactionCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpGet(CustomerTransactionRoute.Search)]
        public async Task<IActionResult> SearchCustomers(string item)
        {
            var query = new SearchCustTransactionQuery(item);
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }

}
