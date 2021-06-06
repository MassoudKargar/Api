namespace Api.Domain.Models.Orders
{
    public class OrderItem
    {
        public OrderItem(int orderId, int productId, decimal price)
        {
            OrderId = orderId;
            ProductId = productId;
            Price = price;
        }

        public int Id { get; private set; }
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public decimal Price { get; private set; }
    }
}
