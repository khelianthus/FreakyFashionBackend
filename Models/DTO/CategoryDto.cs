using FreakyFashion.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Models.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
       
        public string? UrlSlug { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
