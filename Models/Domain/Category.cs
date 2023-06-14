using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Models.Domain
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string? UrlSlug { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
