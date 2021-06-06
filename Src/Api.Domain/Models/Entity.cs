using System.Collections.Generic;
using MediatR;

namespace Api.Domain.Models
{
    public class Entity
    {
        public List<INotification> DomainEvents;
        public Entity()
        {
            DomainEvents = new();
        }
        public void AddDomainEvent(INotification @event)
        {
            DomainEvents.Add(@event);
        }
        public void ClearDomainEvrnts()
        {
            DomainEvents.Clear();
        }
    }
}
