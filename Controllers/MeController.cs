using Microsoft.AspNetCore.Mvc;
using Tripzy.Core.Dtos;
using Tripzy.Core.Entity;
using Tripzy.Core.Mapper;
using Tripzy.Core.Services;
using Tripzy.Infrastructure.Service;

namespace Tripzy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeController : Controller
    {
        public IPlaceCategoryService placeCategoryService;

        public MeController(IPlaceCategoryService placeCategoryService)
        {
            this.placeCategoryService = placeCategoryService;
        }

        
        [HttpGet("feed")]
        public async Task<List<PlaceCategoryDto>> Feed()
        {
            var placeCategories = await this.placeCategoryService.GetAllAsync();
            return PlaceCategoryMapper.ToDtoList(placeCategories.ToList());
        }

    }
}
