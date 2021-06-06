using System;
using System.Collections.Generic;
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
            b.HasData(new List<Product>()
            {
                new (1,"title","body",DateTime.Now,10000,"imgPath","filePath",1,true,false,false),
                new (2,"title_2","body_2",DateTime.Now,10000,"imgPath_2","filePath_2",2,true,false,false)
            });
        }
    }
}
