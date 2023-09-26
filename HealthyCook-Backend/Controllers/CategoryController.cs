using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using HealthyCook_Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace HealthyCook_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Agregar una nueva categoria a la lista
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            try
            {
                await _categoryService.CreateCategory(category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtener todas las categorias disponibles
        /// </summary>
        /// <returns></returns>
        [Route("GetAllCategories")]
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                var categoriesList = await _categoryService.GetListCategories();
                return Ok(categoriesList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
