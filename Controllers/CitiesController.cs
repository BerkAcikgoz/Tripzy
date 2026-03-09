using Microsoft.AspNetCore.Mvc;
using Tripzy.Core.Dtos;
using Tripzy.Core.Entity;
using Tripzy.Core.Mapper;
using Tripzy.Core.Services;

namespace Tripzy.Controllers
{
    [ApiController]
   [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        public ICityService cityService;

        public CitiesController(ICityService cityService)
        {
            this.cityService = cityService;
        }
   
        [HttpGet]
        public async Task<List<CityDto>> GetCities()
        {
            var cities = await this.cityService.GetAllAsync();
            return CityMapper.ToDtoList(cities.ToList());  
        }

        [HttpGet("getCityById/{Id}")]
        public async Task<CityDto> GetCityById(int Id)
        {   
            var city = await this.cityService.GetByIdAsync(Id);
            return CityMapper.ToDto(city);  
        }

    }
}
