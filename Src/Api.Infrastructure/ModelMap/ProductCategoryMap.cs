using Api.Domain.Models.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Collections.Generic;

namespace Api.Infrastructure.ModelMap
{
    public class ProductCategoryMap : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> b)
        {
            b.ToTable("ProductCategories");
            b.HasKey(k => k.Id);
            b.Property(p => p.Id).ValueGeneratedOnAdd();
            b.HasData(new List<ProductCategory>()
            {
                new(1,"Catrgory 1","Description 1"),
                new(2,"Catrgory 2","Description 2"),
                new(3,"Catrgory 3","Description 3"),
                new(4,"Catrgory 4","Description 4"),
                new(5,"Catrgory 5","Description 5")
            });
        }
    }
}
