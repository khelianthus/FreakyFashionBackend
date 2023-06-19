using FreakyFashion.Models.Domain;

namespace FreakyFashion.Models.DTO
{
    public class EditProductDto
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public decimal? Price { get; set; }

        public string? Sku { get; set; }

        public Uri? ImageUrl { get; set; }

        public string? UrlSlug { get; set; }

        public string? Color { get; set; }

        public int? CategoryId { get; set; }
    }
}
