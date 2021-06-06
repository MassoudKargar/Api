using System;
using Api.Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infrastructure.ModelMap
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> b)
        {
            b.HasData(new AppUser()
            {
                Id = 1,
                Email = "info@api.com",
                CreatedAt = DateTime.Now,
                PhoneNumber = "09213641310",
                PhoneNumberConfirmed = true,
                LoginCount = 0,
                PurchasedNumber = 0,
                IsActive = true,
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                LockoutEnabled = false,
                AccessFailedCount = 0
            });
        }
    }
}
