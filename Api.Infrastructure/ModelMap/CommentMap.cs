using Api.Domain.Models.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infrastructure.ModelMap
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> b)
        {
            b.ToTable("Comments");
            b.HasKey(k => k.Id);
            b.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
