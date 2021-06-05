using Api.Domain.Models.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infrastructure.ModelMap
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> b)
        {
            b.ToTable("Products");
            b.HasKey(k => k.Id);
            b.Property(p => p.Id).ValueGeneratedOnAdd();
            b.Property(p => p.Title).HasMaxLength(64);
            b.Property(p => p.Body).HasMaxLength(1024);
        }
    }
}
