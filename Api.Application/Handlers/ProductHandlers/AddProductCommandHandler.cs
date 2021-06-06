using System;
using System.Threading;
using System.Threading.Tasks;
using Api.Domain.CommandResult;
using Api.Domain.Commands;
using Api.Domain.Contracts.Repositories;
using Api.Domain.Models.Products;
using MediatR;

namespace Api.Application.Handlers.ProductHandlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, AddProductResult>
    {
        public AddProductCommandHandler(IProductRepository productRepository) 
        {
            ProductRepository = productRepository;
        }

        private IProductRepository ProductRepository { get; }

        public async Task<AddProductResult> Handle(AddProductCommand cmd, CancellationToken cancellationToken)
        {
            Product v = new(0, cmd.Title, cmd.Body, DateTime.Now, cmd.Price, cmd.ImgPath, cmd.FilePhat, cmd.ProductCategoryId, cmd.IsVisible, cmd.IsDeleted, cmd.IsSalleble);
            await ProductRepository.AddAsync(v);
            return new AddProductResult(v.Id);
        }
    }
}
