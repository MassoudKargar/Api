using System;

namespace Api.Domain.Models.Orders
{
    public class OrderItem
    {
        public OrderItem(int id, int orderId, int productId, decimal price, DateTime createdAt)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public decimal Price { get; private set; }
        public DateTime CreatedAt { get; private set; }

    }
}
