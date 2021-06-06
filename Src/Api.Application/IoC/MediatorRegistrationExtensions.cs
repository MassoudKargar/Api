using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using Api.Domain.Commands.Products;
using Api.Application.Handlers.ProductHandlers;

namespace Api.Application.IoC
{
    public static class MediatorRegistrationExtensions
    {
        public static void RegisterMediator(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(typeof(AddProductCommand).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(AddProductCommandHandler).GetTypeInfo().Assembly);
        }
    }
}
