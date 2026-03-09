using Tripzy.Core.Entity;

namespace Tripzy.Core.Services
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllAsync();
        Task<City> GetByIdAsync(int id);
    }
}