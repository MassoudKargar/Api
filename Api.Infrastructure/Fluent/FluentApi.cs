using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace Api.Infrastructure.Fluent
{
    internal static class FluentApi
    {
        internal static void ApplyFluentApi(this ModelBuilder b)
        {
            b.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
