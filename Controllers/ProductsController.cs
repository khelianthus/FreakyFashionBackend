using FreakyFashion.Data;
using FreakyFashion.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreakyFashion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProduct(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Brand = product.Brand,
                Price = product.Price,
                Sku = product.Sku,
                ImageUrl = product.ImageUrl,
                UrlSlug = product.UrlSlug,
                Likes = product.Likes,
                Color = product.Color,
                Category = product.Category,
                CreatedAt = product.CreatedAt
            };

            return productDto;
        }
    }
}
