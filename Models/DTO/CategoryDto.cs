using FreakyFashion.Models.Domain;

namespace FreakyFashion.Models.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
