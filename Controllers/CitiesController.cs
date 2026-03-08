using Microsoft.AspNetCore.Mvc;
using Tripzy.Core.Dtos;
using Tripzy.Core.Entity;
using Tripzy.Core.Mapper;
using Tripzy.Core.Services;

namespace Tripzy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController : Controller
    {
        public ICityService cityService;

        public CitiesController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        public List<CityDto> GetCities()
        {
            return CityMapper.ToDtoList(this.cityService.GetCities());  
        }

    }
}
