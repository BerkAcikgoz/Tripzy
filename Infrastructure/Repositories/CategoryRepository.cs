using Tripzy.Core.Models;
using Tripzy.Infrastructure.Data;

namespace Tripzy.Core.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Category> GetCategories() => _context.Category.ToList();
    }
}