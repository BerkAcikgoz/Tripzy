using Tripzy.Core.Models;
using Tripzy.Core.Repositories;
using Tripzy.Core.Services;

namespace Tripzy.Infrastructure.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repo;

        public CategoryService(ICategoryRepository repo)
        {
            this.repo = repo;
        }

        public List<Category> GetCategories()
        {
           return repo.GetCategories();
        }
    }
}