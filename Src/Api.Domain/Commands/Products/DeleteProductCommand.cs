using Api.Domain.CommandResult.Products;
using MediatR;

namespace Api.Domain.Commands.Products
{
   public class DeleteProductCommand : IRequest<DeleteProductResult>
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
 