using Tripzy.Core.Entity;
using Infrastructure.Repositories;
using Tripzy.Infrastructure.Data;

namespace Tripzy.Core.Repositories
{
public class CityRepository : BaseRepository<City>, ICityRepository
{
    public CityRepository(AppDbContext context) : base(context)
    {
    }
}
}