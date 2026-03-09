using Tripzy.Core.Entity;

namespace Tripzy.Core.Repositories
{
    public interface IPlaceCategoryRepository
    {
        Task<IEnumerable<PlaceCategory>> GetAllAsync();
        Task<PlaceCategory> GetByIdAsync(object id);
    }
}