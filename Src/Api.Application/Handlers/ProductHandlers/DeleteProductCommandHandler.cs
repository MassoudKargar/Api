using System.Threading;
using System.Threading.Tasks;
using Api.Domain.CommandResult.Products;
using Api.Domain.Commands.Products;
using Api.Domain.Contracts.Repositories;
using MediatR;

namespace Api.Application.Handlers.ProductHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeleteProductResult>
    {
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        private IProductRepository ProductRepository { get; }

        public async Task<DeleteProductResult> Handle(DeleteProductCommand cmd, CancellationToken cancellationToken)
        {
            var product = await ProductRepository.FindAsync(cmd.Id);
            product.Deleted();
            await ProductRepository.Save(product);
            return new DeleteProductResult(product.Id);
        }
    }
}
