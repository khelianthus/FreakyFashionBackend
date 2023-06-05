using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Models.DTO
{
    public class CredentialsDto
    {
        [MaxLength(25)]
        public string UserName { get; set; }

        [MaxLength(25)]
        public string Password { get; set; }
    }
}
