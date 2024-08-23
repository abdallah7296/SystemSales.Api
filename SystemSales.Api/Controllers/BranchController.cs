using MediatR;
using Microsoft.AspNetCore.Mvc;
using SystemSales.Core.Feature.Branches.Commands.Models;

namespace SystemSales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BranchController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBranch([FromBody] CreateBranchesCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Model State");
            }

            var response = await _mediator.Send(command);

            return StatusCode((int)response.StatusCode, response);
        }
    }
}
