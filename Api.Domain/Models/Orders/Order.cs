using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Collections.Generic;

namespace Api.Domain.Models.Orders
{
    public class Order
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        private readonly List<OrderItem> _orderItems;
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;
        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public Order(int id, int userId, List<OrderItem> orderItems) : this()
        {
            Id = id;
            UserId = userId;
            _orderItems = orderItems;
        }
    }
    
}
