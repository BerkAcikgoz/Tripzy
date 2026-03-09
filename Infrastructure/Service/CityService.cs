using Tripzy.Core.Entity;
using Tripzy.Core.Repositories;
using Tripzy.Core.Services;

namespace Tripzy.Infrastructure.Service
{
  
public class CityService : ICityService
{
    private readonly ICityRepository repo;

    public CityService(ICityRepository repo)
    {
        this.repo = repo;
    }

    public async Task<IEnumerable<City>> GetAllAsync()
    {
        return await repo.GetAllAsync();
    }

    public async Task<City> GetByIdAsync(int id)
    {
        return await repo.GetByIdAsync(id);
    }
}
}