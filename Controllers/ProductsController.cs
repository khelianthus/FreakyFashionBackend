using FreakyFashion.Data;
using FreakyFashion.Models.Domain;
using FreakyFashion.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;

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

            return Ok(productDto);
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

        [HttpGet("/backoffice/productdetails/{urlSlug}")]
        public ActionResult<ProductDto> GetProductByUrlSlug(string urlSlug)
        {

            Console.WriteLine(urlSlug);

            var product = context.Products
                .Include(x => x.Category)
                .FirstOrDefault(x => x.UrlSlug == urlSlug);

            if (product == null)
            {
                return NotFound();
            }

            var productDto = ToProductDto(product);

            return productDto;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateProduct([FromBody] NewProductDto newProductDto)
        {
            var category = context.Categories.FirstOrDefault(c => c.Id == newProductDto.CategoryId);
            if (category == null)
            {
                return BadRequest("Invalid category ID.");
            }

            var product = new Product
            {
                Name = newProductDto.Name,
                Description = newProductDto.Description,
                Brand = newProductDto.Brand,
                Price = newProductDto.Price,
                Sku = newProductDto.Sku,
                ImageUrl = newProductDto.ImageUrl,
                Color = newProductDto.Color,
                CreatedAt = newProductDto.CreatedAt,
                Category = category
            };

            product.UrlSlug = $"{RemoveSpecialCharacters(product.Color)}-{RemoveSpecialCharacters(product.Name)}"
                .Replace(" ", "-")
                .ToLower();

            product.Likes = 0;

            context.Products.Add(product);
            context.SaveChanges();

            var productDto = ToProductDto(product);
            
            return Created("", productDto);

        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> EditProduct(int id, [FromBody] EditProductDto productDto)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(productDto.Name))
            {
                product.Name = productDto.Name;
            }

            if (!string.IsNullOrEmpty(productDto.Description))
            {
                product.Description = productDto.Description;
            }

            if (!string.IsNullOrEmpty(productDto.Brand))
            {
                product.Brand = productDto.Brand;
            }

            if (productDto.Price.HasValue)
            {
                product.Price = productDto.Price.Value;
            }

            if (!string.IsNullOrEmpty(productDto.Sku))
            {
                product.Sku = productDto.Sku;   
            }

            if (productDto.ImageUrl != null)
            {
                product.ImageUrl = productDto.ImageUrl;
            }

            if (!string.IsNullOrEmpty(productDto.Color))
            {
                product.Color = productDto.Color;
            }

            if (productDto.CategoryId.HasValue)
            {
                var category = context.Categories.FirstOrDefault(c => c.Id == productDto.CategoryId.Value);
                if (category != null)
                {
                    product.Category = category;
                }
            }

            product.UrlSlug = $"{RemoveSpecialCharacters(product.Color)}-{RemoveSpecialCharacters(product.Name)}"
                .Replace(" ", "-")
                .ToLower();

            context.Update(product);
            await context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);

            context.Products.Remove(product);
            context.SaveChanges();

            return Ok(product);
        }

        private string RemoveSpecialCharacters(string input)
        {
            string normalized = input
                .Replace("å", "a")
                .Replace("ä", "a")
                .Replace("ö", "o");

            string pattern = "[^a-zA-Z0-9-]";
            string result = Regex.Replace(normalized, pattern, "");

            return result;
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
