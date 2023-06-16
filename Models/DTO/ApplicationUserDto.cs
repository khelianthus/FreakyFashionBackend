using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Models.DTO
{
    public class ApplicationUserDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public int? PostalCode { get; set; }
    }
}
