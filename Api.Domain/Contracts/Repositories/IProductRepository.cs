using System.Threading.Tasks;
using Api.Domain.Models.Products;

namespace Api.Domain.Contracts.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product> FindAsync(int id);
        Task Save(Product product);
    }
}
