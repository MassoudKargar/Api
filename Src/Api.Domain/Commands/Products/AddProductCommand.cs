using Api.Domain.CommandResult.Products;
using MediatR;

namespace Api.Domain.Commands.Products
{
    public class AddProductCommand : IRequest<AddProductResult>
    {
        public string Title { get; set; } 
        public string Body { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public string FilePhat { get; set; }
        public short ProductCategoryId { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSalleble { get; set; }
    }
}
