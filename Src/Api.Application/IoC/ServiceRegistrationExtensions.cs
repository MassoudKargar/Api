using Api.Application.Contracts;
using Api.Application.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Application.IoC
{
    public static class ServiceRegistrationExtensions
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAddProductCommandFactory, AddProductCommandFactory>();
        }
    }
}
