﻿using FreakyFashion.Models.Domain;

namespace FreakyFashion.Models.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public string Sku { get; set; }

        public Uri ImageUrl { get; set; }

        public string? UrlSlug { get; set; }

        public int? Likes { get; set; }

        public string Color { get; set; }

        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
