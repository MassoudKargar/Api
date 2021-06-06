using MediatR;

namespace Api.Domain.DomainEvents.Orders
{
    public class OederAddedEvent : INotification
    {
        public OederAddedEvent(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; set; }
    }
}
