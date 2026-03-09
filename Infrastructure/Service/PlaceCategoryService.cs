using Tripzy.Core.Entity;
using Tripzy.Core.Repositories;
using Tripzy.Core.Services;

namespace Tripzy.Infrastructure.Service
{
    public class PlaceCategoryService : IPlaceCategoryService
    {
        private readonly IPlaceCategoryRepository repo;

        public PlaceCategoryService(IPlaceCategoryRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<PlaceCategory>> GetAllAsync()
        {
            return await repo.GetAllAsync();
        }

        public async Task<PlaceCategory> GetByIdAsync(int id)
        {
            return await repo.GetByIdAsync(id);
        }
    }
}