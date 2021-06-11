using System.Threading.Tasks;
using Api.Application.Contracts;
using Api.Core.Common.Models;
using Api.Domain.Commands.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Web.Controllers
{
    [ApiController]
    [Route(template: "[Controller]")]

    public class ProductController : ControllerBase
    {
        public ProductController(IMediator mediator, IAddProductCommandFactory factory)
        {
            Mediator = mediator;
            Factory = factory;
        }

        private IMediator Mediator { get; }
        public IAddProductCommandFactory Factory { get; }

        /// <summary>
        /// Add Product Async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost, Route(template: "[action]")]
        public async Task<IActionResult> AddProductAsync([FromForm] AddProductCommandModels model)
        {
            var command = await Factory.CreateAsync(model);
            //todo: save file

            //todo: create AddProductCommand

            var v = await Mediator.Send(command);
            return Ok(v);
        }

        /// <summary>
        /// Update Product Async
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut, Route(template: "[action]")]
        public async Task<IActionResult> UpdateProductAsync(UpdateProductCommand command)
        {
            var v = await Mediator.Send(command);
            return Ok(v);
        }
        /// <summary>
        /// Delete Product Async
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete, Route(template: "[action]")]
        public async Task<IActionResult> DeleteProductAsync(DeleteProductCommand command)
        {
            var v = await Mediator.Send(command);
            return Ok(v);
        }
    }
}
