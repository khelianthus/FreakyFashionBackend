using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string Email { get ; set; }

        [MaxLength(250)]
        public string? Address { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }

        [MaxLength(50)]
        public string? Region { get; set; }

        [MaxLength(5)]
        public int? PostalCode { get; set; }
    }
}
