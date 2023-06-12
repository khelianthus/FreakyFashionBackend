using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace FreakyFashion.Models.Domain
{
    [Index(nameof(Sku), IsUnique = true)]
    [Index(nameof(UrlSlug), IsUnique = true)]
    public class Product
    {
        // När vi hämtar från databas så gör vi det genom context.Products

        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        [MaxLength(50)]
        public string Brand { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Sku { get; set; }

        public Uri ImageUrl { get; set; }

        [MaxLength(50)]
        public string? UrlSlug { get; set; }

        public int? Likes { get; set; }

        public string Color { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
