using System.Threading.Tasks;
using Api.Application.ViewModel;

namespace Api.Application.IService
{
    public interface IProductService
    {
        /// <summary>
        /// Add Product
        /// </summary>
        /// <param name="model">ProduciId</param>
        /// <returns></returns>
        Task<int> AddProduct(AddProductViewModel model);
    }
}
