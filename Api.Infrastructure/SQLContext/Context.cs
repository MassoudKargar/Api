
using Api.Domain.Models.Orders;
using Api.Domain.Models.Products;
using Api.Domain.Models.Tags;
using Api.Infrastructure.Fluent;
using Api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Infrastructure.SqlContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

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
    }
    public class BloggingContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer(Connection.Connectionlocal, a => a.MigrationsAssembly(assemblyName: "Api.Infrastructure"));

            return new Context(optionsBuilder.Options);
        }
    }
}
