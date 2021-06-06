using System.Threading.Tasks;
using Api.Domain.Contracts.Repositories;
using Api.Domain.Models.Orders;
using Api.Infrastructure.SqlContext;

namespace Api.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository(Context db)
        {
            _db = db;
        }

        private readonly Context _db;

        async Task IOrderRepository.SaveAsync(Order order)
        {
            _db.Orders.Update(order);
            await _db.SaveEntitiesAsync();
        }
    }
}
