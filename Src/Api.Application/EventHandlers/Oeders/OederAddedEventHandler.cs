using System.Threading;
using System.Threading.Tasks;
using Api.Domain.Contracts.Repositories;
using Api.Domain.DomainEvents.Orders;
using Api.Domain.Models.Users;
using MediatR;

namespace Api.Application.EventHandlers.Oeders
{
    public class OederAddedEventHandler : INotificationHandler<OederAddedEvent>
    {
        public OederAddedEventHandler(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        private IUserRepository UserRepository { get; }

        public async Task Handle(OederAddedEvent notification, CancellationToken cancellationToken)
        {
            var appUser = await UserRepository.Get(notification.UserId);
            appUser.UpdatePurchasedNumder();
            UserRepository.Save(appUser);
        }
    }
}
