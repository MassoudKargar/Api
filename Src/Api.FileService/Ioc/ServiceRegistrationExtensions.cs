using System.IO.Abstractions;
using Api.Core.Common.Contracs;
using Api.FileService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.FileService.IoC
{
    public static class ServiceRegistrationExtensions
    {
        public static void RegisterFileServiceServices(this IServiceCollection services)
        {
            services.AddScoped<IProductImageServise, IProductImageService>();
            services.AddScoped<IFileSystem, FileSystem>();
        }
    }
}
