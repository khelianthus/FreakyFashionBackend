using FreakyFashion.Data;
using FreakyFashion.Models.Domain;
using FreakyFashion.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FreakyFashion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        private readonly ILogger<ProductsController> logger;

        public ProductsController(ApplicationDbContext context, ILogger<ProductsController> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProduct(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var productDto = ToProductDto(product);

            return productDto;
        }

        //http://localhost:5000/products?search={search}

        [HttpGet]
        public IEnumerable<ProductDto> GetProducts([FromQuery] string? search)
        {
            var decodedSearchTerm = search is null
            ? null
            : Uri.UnescapeDataString(search);

            logger.LogInformation("Search term: {SearchTerm}", search);

            var products = search is null
                ? context.Products.ToList()
                : context.Products.Where(x =>
                    x.Name.Contains(decodedSearchTerm) ||
                    x.Color.Contains(decodedSearchTerm) ||
                    x.Sku.Contains(decodedSearchTerm)).ToList();

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
