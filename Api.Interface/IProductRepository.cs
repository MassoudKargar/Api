using System.Threading.Tasks;
using Api.Domain.Models.Products;

namespace Api.Interface
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product> FindAsync(int id);
    }
}
