using FreakyFashion.Data;
using FreakyFashion.Models.Domain;
using FreakyFashion.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ApplicationDbContext context;

    public CategoriesController(ApplicationDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IEnumerable<CategoryDto> GetCategories()
    {
        var categories = context.Categories
             .Include(x => x.Products) //Används ev. inte
             .ToList();

        var categoryDtos = categories.Select(ToCategoryDto);

        return categoryDtos;
    }

    [HttpGet("{urlSlug}")]
    public ActionResult<CategoryDto> GetCategory(string urlSlug)
    {
        var category = context.Categories
            .Include(x => x.Products)
            .FirstOrDefault(x => x.UrlSlug == urlSlug);

        if (category == null)
        {
            return NotFound();
        }

        var categoryDto = ToCategoryDto(category);

        return categoryDto;
    }

    private CategoryDto ToCategoryDto(Category category)
          => new CategoryDto
          {
              Id = category.Id,
              Name = category.Name,
              UrlSlug = category.UrlSlug,
              Products = category.Products
          };
}