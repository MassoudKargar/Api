using Api.Domain.CommandResult;
using MediatR;

namespace Api.Domain.Commands
{
    public class UpdateProductCommand : IRequest<UpdateProductResult>
    {
        public int Id { get; set; }
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
