using Api.Application.IService;
using Api.Application.Services;
using Api.Domain.Contracts.Repositories;
using Api.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Application.IoC
{
    public static class ServiceRegistrationExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
