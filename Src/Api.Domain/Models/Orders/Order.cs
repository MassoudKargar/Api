using System;
using System.Collections.Generic;
using Api.Domain.Commands.Orders;
using Api.Domain.DomainEvents.Orders;

namespace Api.Domain.Models.Orders
{
    public class Order : Entity
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;
        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public Order(int id, int userId, DateTime createdAt, List<OrderItem> orderItems) : this()
        {
            Id = id;
            UserId = userId;
            CreatedAt = createdAt;
            _orderItems = orderItems;
        }
        public Order(int id, int userId, DateTime createdAt) : this()
        {
            Id = id;
            UserId = userId;
            CreatedAt = createdAt;
        }

        public void AddItem(List<OrderItemCommand> cmdOrderItems)
        {
            foreach (var item in cmdOrderItems)
                _orderItems.Add(new OrderItem(Id,item.ProductId,item.Price));

            AddDomainEvent(new OederAddedEvent(UserId));
        }

    }

}
