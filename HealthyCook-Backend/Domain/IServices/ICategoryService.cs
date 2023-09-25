using HealthyCook_Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IServices
{
    public interface ICategoryService
    {
        Task CreateCategory(Category category);
        Task<List<Category>> GetListCategories();
    }
}
