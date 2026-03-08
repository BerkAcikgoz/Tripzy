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

        public List<City> GetCities()
        {
            return this.repo.GetCities();
        }
    }
}