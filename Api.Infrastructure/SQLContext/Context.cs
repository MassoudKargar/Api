
using System.Threading;
using System.Threading.Tasks;
using Api.Domain.Models.Orders;
using Api.Domain.Models.Products;
using Api.Domain.Models.Tags;
using Api.Domain.Models.Users;
using Api.Infrastructure.Extensions;
using Api.Infrastructure.Fluent;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Infrastructure.SqlContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options,IMediator mediator) : base(options)
        {
            GetMediator = mediator;
        }
        private IMediator GetMediator { get; }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.ApplyFluentApi();
            //b.ApplySeed();
        }


        public async Task<int> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await GetMediator.DispatchDomainEventAsync(this);
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }
    }


    /*public class BloggingContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer(Connection.Connectionlocal, a => a.MigrationsAssembly(assemblyName: "Api.Infrastructure"));

            return new Context(optionsBuilder.Options,);
        }
    }*/
}
