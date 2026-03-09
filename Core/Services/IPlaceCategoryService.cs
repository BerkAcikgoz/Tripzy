using Tripzy.Core.Entity;

namespace Tripzy.Core.Services
{
    public interface IPlaceCategoryService
    {
        Task<IEnumerable<PlaceCategory>> GetAllAsync();
        Task<PlaceCategory> GetByIdAsync(int id);
    }
}