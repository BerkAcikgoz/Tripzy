using Tripzy.Core.Dtos;
using Tripzy.Core.Entity;

namespace Tripzy.Core.Mapper
{
    public class CityMapper
    {
        public static CityDto ToDto(City City)
        {
            return new CityDto
            {
                Id = City.Id,
                Name = City.Name,
                CountryId = City.CountryId
            };
        }

        public static City ToEntity(CityDto CityDto)
        {
            return new City
            {
              Id = CityDto.Id,
                Name = CityDto.Name,
                CountryId = CityDto.CountryId
            };
        }

        public static List<CityDto> ToDtoList(List<City> categories)
        {
            return categories.Select(ToDto).ToList();
        }

        public static List<City> ToEntityList(List<CityDto> CityDtos)
        {
            return CityDtos.Select(ToEntity).ToList();
        }
    }
}
