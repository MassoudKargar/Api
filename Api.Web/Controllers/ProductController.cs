using System.Threading.Tasks;
using Api.Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Web.Controllers
{
    [ApiController]
    [Route(template: "[Controller]")]

    public class ProductController : ControllerBase
    {
        public ProductController(IMediator mediator)
        {
            Mediator = mediator;
        }

        private IMediator Mediator { get; }

        [HttpPost, Route(template: "[action]")]
        public async Task<IActionResult> AddProductAsync(AddProductCommand command)
        {
            var v = await Mediator.Send(command);
            return Ok(v);
        }

        [HttpPost, Route(template: "[action]")]
        public async Task<IActionResult> UpdateProductAsync(UpdateProductCommand command)
        {
            var v = await Mediator.Send(command);
            return Ok(v);
        }
    }
}
