using System.Threading.Tasks;
using Api.Domain.Models.Orders;

namespace Api.Domain.Contracts.Repositories
{
    public interface IOrderRepository
    {
        Task SaveAsync(Order order);
    }
}
