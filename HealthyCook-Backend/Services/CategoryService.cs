using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task CreateCategory(Category category)
        {
            await _categoryRepository.CreateCategory(category);
        }

        public async Task<List<Category>> GetListCategories()
        {
            return await _categoryRepository.GetListCategories();
        }
    }
}
