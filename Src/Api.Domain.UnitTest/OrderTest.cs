using System;
using System.Collections.Generic;
using System.Linq;
using Api.Domain.Commands.Orders;
using Api.Domain.DomainEvents.Orders;
using Api.Domain.Models.Orders;
using Xunit;

namespace Api.Domain.UnitTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveDomainEvent_WhenAnOrderItemsIsAdded()
        {
            Order order = new(1, 1, DateTime.Now);
            List<OrderItemCommand> orderItem = new()
            {
                new()
                {
                    Id = 1,
                    OrderId = 10,
                    ProductId = 1,
                    Price = 100
                }
            };
            order.AddItem(orderItem);

            var expected = typeof(OederAddedEvent);

            var domainEvents = order.DomainEvents.First();

            var actual = domainEvents.GetType();
            Assert.Equal(expected, actual);

        }
    }
}
