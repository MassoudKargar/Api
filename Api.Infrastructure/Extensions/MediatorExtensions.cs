using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Models;
using Api.Infrastructure.SqlContext;
using MediatR;

namespace Api.Infrastructure.Extensions
{
    public static class MediatorExtensions
    {
        public static async Task DispatchDomainEventAsync(this IMediator mediator, Context ctx)
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            domainEntities.ToList().ForEach(entity => entity.Entity.ClearDomainEvrnts());

            var task = domainEvents
                .Select(async (domainEvents) =>
                {
                    await mediator.Publish(domainEvents);
                });

            await Task.WhenAll(task);
        }
    }
}
