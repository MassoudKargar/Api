using System.Threading;
using System.Threading.Tasks;
using Api.Domain.CommandResult;
using Api.Domain.Commands;
using Api.Domain.Contracts.Repositories;
using MediatR;

namespace Api.Application.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult>
    {
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        private IProductRepository ProductRepository { get; }

        public async Task<UpdateProductResult> Handle(UpdateProductCommand cmd, CancellationToken cancellationToken)
        {
            var product = await ProductRepository.FindAsync(cmd.Id);
            product.Update(cmd);
            await ProductRepository.Save(product);
            return new(product.Id);
        }
    }
}
