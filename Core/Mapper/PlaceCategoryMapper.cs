using Tripzy.Core.Dtos;
using Tripzy.Core.Entity;

namespace Tripzy.Core.Mapper
{
    public class PlaceCategoryMapper
    {
        public static PlaceCategoryDto ToDto(PlaceCategory placeCategory)
        {
            return new PlaceCategoryDto
            {
                Id = placeCategory.Id,
                Name = placeCategory.Name,
                Icon = placeCategory.Icon
            };
        }

        public static PlaceCategory ToEntity(PlaceCategoryDto placeCategoryDto)
        {
            return new PlaceCategory
            {
                Id = placeCategoryDto.Id,
                Name = placeCategoryDto.Name,
                Icon = placeCategoryDto.Icon
            };
        }

        public static List<PlaceCategoryDto> ToDtoList(List<PlaceCategory> placeCategories)
        {
            return placeCategories.Select(ToDto).ToList();
        }

        public static List<PlaceCategory> ToEntityList(List<PlaceCategoryDto> placeCategoryDtos)
        {
            return placeCategoryDtos.Select(ToEntity).ToList();
        }
    
    }
}
