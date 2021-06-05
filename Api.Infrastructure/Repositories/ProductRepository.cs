using System.Threading.Tasks;
using Api.Domain.Models.Products;
using Api.Infrastructure.SqlContext;
using Api.Interface;

namespace Api.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(Context db)
        {
            _db = db;
        }

        private readonly Context _db;

        async Task IProductRepository.AddAsync(Product product)
        {
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
        }

        async Task<Product> IProductRepository.FindAsync(int id)
        {
            return await _db.Products.FindAsync(id);
        }
    }
}
