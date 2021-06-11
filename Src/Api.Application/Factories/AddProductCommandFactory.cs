using System.Threading.Tasks;
using Api.Core.Common.Contracs;
using Api.Core.Common.Models;
using Api.Domain.Commands.Products;
using Api.Application.Contracts;
using System;

namespace Api.Application.Factories
{
    public class AddProductCommandFactory : IAddProductCommandFactory
    {
        private IProductImageServise ProductImageServise { get; }
        public AddProductCommandFactory(IProductImageServise productImageServise)
        {
            ProductImageServise = productImageServise;
        }

        public void CreateAsync(object addProductCommandModel)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AddProductCommand> CreateAsync(AddProductCommandModels model)
        {
            if (model.File is null)
                throw new ArgumentNullException();
            var imagePath = await ProductImageServise.SaveImageAcync(model.File);
            model.ImgPath = imagePath;
            return new(model);
        }
    }
}
