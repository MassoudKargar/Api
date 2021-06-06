using System;
using System.Threading;
using System.Threading.Tasks;
using Api.Domain.CommandResult.Orders;
using Api.Domain.Commands.Orders;
using Api.Domain.Contracts.Repositories;
using Api.Domain.Models.Orders;
using MediatR;

namespace Api.Application.Handlers.OrderHandlers
{
    public class AddOrderCommandHandlers : IRequestHandler<AddOrderCommand, AddOrderDto>
    {
        public AddOrderCommandHandlers(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        private IOrderRepository OrderRepository { get; }
        public async Task<AddOrderDto> Handle(AddOrderCommand cmd, CancellationToken cancellationToken)
        {
            Order order = new(0, 1,DateTime.Now);
            order.AddItem(cmd.OrderItems);
            await OrderRepository.SaveAsync(order);
            return new();
        }
    }
}
