using System;
using System.Threading.Tasks;
using Api.Application.ViewModel;
using Api.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Web.Controllers
{
    [ApiController]
    [Route(template: "[Controller]")]

    public class ProductController : ControllerBase
    {
        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }

        private IProductService ProductService { get; }

        [HttpPost, Route(template: "[action]")]
        public async Task<IActionResult> AddProductAsync(AddProductViewModel model)
        {
            var v = await ProductService.AddProduct(model);
            return Ok(v);
        }
    }
}
