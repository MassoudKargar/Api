using System;
using System.Threading.Tasks;
using Api.Application.ViewModel;
using Api.Domain.Models.Products;
using Api.Interface;

namespace Api.Services
{
    public class ProductService : IProductService
    {
        public ProductService(IProductRepository repository)
        {
            Repository = repository;
        }

        private IProductRepository Repository { get; }
        /// <summary>
        /// Add Product
        /// </summary>
        /// <param name="model">ProduciId</param>
        /// <returns></returns>
        async Task<int> IProductService.AddProduct(AddProductViewModel model)
        {
            Product v = new(0, model.Title, model.Body, DateTime.Now, model.Price, model.ImgPath, model.FilePhat, model.ProductCategoryId, model.IsVisible, false, model.IsSalleble);
            await Repository.AddAsync(v);
            return v.Id;
        }
    }
}
