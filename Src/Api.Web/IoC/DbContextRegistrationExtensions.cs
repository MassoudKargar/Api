using Api.Infrastructure;
using Api.Infrastructure.SqlContext;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Web.IoC
{
    public static class StartupExtensions
    {
        public static void PerformDbContextRegistration(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(connectionString: Connection.Connectionlocal, b =>
                    b.MigrationsAssembly(assemblyName: "Api.Infrastructure"));
                options.EnableDetailedErrors(true);
            });
        }
    }
}
