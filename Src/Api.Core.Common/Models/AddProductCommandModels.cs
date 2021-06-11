using Api.Domain.Commands.Products;
using Microsoft.AspNetCore.Http;

namespace Api.Core.Common.Models
{
    public class AddProductCommandModels : AddProductCommand
    {
        public IFormFile File { get; set; }
    }
}
