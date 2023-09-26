using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.Models;
using HealthyCook_Backend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AplicationDbContext _context;
        public CategoryRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateCategory(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetListCategories()
        {
            var categories = await _context.Category
                .ToListAsync();
            return categories;
        }
    }
}
