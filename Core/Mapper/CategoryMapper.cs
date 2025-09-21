using Tripzy.Core.Dtos;
using Tripzy.Core.Models;

namespace Tripzy.Core.Mapper
{
    public class CategoryMapper
    {
        public static CategoryDto ToDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Icon = category.Icon
            };
        }

        public static Category ToEntity(CategoryDto categoryDto)
        {
            return new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                Icon = categoryDto.Icon
            };
        }

        public static List<CategoryDto> ToDtoList(List<Category> categories)
        {
            return categories.Select(ToDto).ToList();
        }

        public static List<Category> ToEntityList(List<CategoryDto> categoryDtos)
        {
            return categoryDtos.Select(ToEntity).ToList();
        }
    }
}
