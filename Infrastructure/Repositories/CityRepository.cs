using Tripzy.Core.Entity;
using Tripzy.Infrastructure.Data;

namespace Tripzy.Core.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _context;

        public CityRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<City> GetCities() => _context.Cities.ToList();
    }
}