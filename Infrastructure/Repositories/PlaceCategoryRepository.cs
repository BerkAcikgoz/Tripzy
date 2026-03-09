using Tripzy.Core.Entity;
using Infrastructure.Repositories;
using Tripzy.Infrastructure.Data;
using Tripzy.Core.Repositories;

namespace Tripzy.Core.Repositories
{
    public class PlaceCategoryRepository : BaseRepository<PlaceCategory>, IPlaceCategoryRepository
    {
       public PlaceCategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}