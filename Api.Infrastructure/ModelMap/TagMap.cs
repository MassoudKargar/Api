using Api.Domain.Models.Tags;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Collections.Generic;

namespace Api.Infrastructure.ModelMap
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> b)
        {
            b.ToTable("Tags");
            b.HasKey(k => k.Id);
            b.Property(p => p.Id).ValueGeneratedOnAdd();
            b.HasData(new List<Tag>()
            {
                new(1,"Tag 1"),
                new(2,"Tag 2"),
                new(3,"Tag 3"),
                new(4,"Tag 4"),
                new(5,"Tag 5")
            });
        }
    }
}
