using Microsoft.AspNetCore.Mvc;
using Tripzy.Core.Dtos;
using Tripzy.Core.Mapper;
using Tripzy.Core.Services;

namespace Tripzy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public ICategoryService categoryService;

        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }


        [HttpGet(Name = "categories")]
        public List<CategoryDto> CategoryList()
        {
            var categories = categoryService.GetCategories();

            return CategoryMapper.ToDtoList(categories);

        }
    }
}
