using Tripzy.Core.Models;

namespace Tripzy.Core.Repositories
{
    public interface ICategoryRepository
    {
      List<Category> GetCategories();
    }
}