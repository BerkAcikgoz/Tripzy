using Tripzy.Core.Entity;

namespace Tripzy.Core.Repositories
{
    public interface ICityRepository
    {
     Task<IEnumerable<City>> GetAllAsync();
     Task<City> GetByIdAsync(object id);
    }
}