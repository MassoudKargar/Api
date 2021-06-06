using Microsoft.AspNetCore.Identity;

using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Models.Users
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser()
        {
        }

        [StringLength(32)]
        public string FiestName { get; set; }
        [StringLength(32)]
        public string LastName { get; set; }
        public string PhotoFileName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public int PurchasedNumber { get; set; }
        public DateTimeOffset LastVisitDate { get; set; }
        public bool Location { get; set; }
        public string Ip { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public int LoginCount { get; set; }

        public void UpdatePurchasedNumder()
        {
            PurchasedNumber += 1;
        }
    }
}
