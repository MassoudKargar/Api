using System;
using System.Collections.Generic;
using Api.Domain.CommandResult.Orders;
using Api.Domain.Models.Orders;
using MediatR;

namespace Api.Domain.Commands.Orders
{
    public class AddOrderCommand : IRequest<AddOrderDto>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<OrderItemCommand> OrderItems { get; set; }
    }
    public class OrderItemCommand
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }

    }
}
