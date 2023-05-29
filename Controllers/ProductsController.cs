using FreakyFashion.Data;
using FreakyFashion.Models.Domain;
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

            // Nedan kan ändras till ->       var productDto = ToProductDto(product);

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

        [HttpGet]
        public IEnumerable<ProductDto> GetProducts([FromQuery] string? name)
        {
            var products = name is null
               ? context.Products.ToList()
               : context.Products.Where(x => x.Name.Contains(name)).ToList();

            var productDtos = products.Select(ToProductDto);

            return productDtos;
        }

        private ProductDto ToProductDto(Product product)
           => new ProductDto
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
    }
 }
