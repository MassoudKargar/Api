using System.Threading.Tasks;
using Api.Domain.Commands.Orders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Web.Controllers
{
    [ApiController]
    [Route(template: "[Controller]")]
    public class OrderController : ControllerBase
    {
        public OrderController(IMediator mediator)
        {
            Mediator = mediator;
        }

        private IMediator Mediator { get; }

        [HttpPost, Route(template: "[action]")]
        public async Task<IActionResult> AddOrderAsync(AddOrderCommand command)
        {
            var v = await Mediator.Send(command);
            return Ok(v);
        }

    }
}
