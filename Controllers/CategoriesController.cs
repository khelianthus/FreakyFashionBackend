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
                .Include(x => x.Products)
                .ToList();

        var categoryDtos = categories.Select(ToCategoryDto);

        return categoryDtos;
    }

    private CategoryDto ToCategoryDto(Category category)
          => new CategoryDto
          {
              Id = category.Id,
              Name = category.Name,
              Products = category.Products
          };
}