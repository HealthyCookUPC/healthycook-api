using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasAyudaController : ControllerBase
    {
        public readonly IConsultasAyudaService _consultaService;
        public ConsultasAyudaController(IConsultasAyudaService consultaService)
        {
            _consultaService = consultaService;
        }

        /// <summary>
        /// Agregar una nueva categoria a la lista
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ConsultasAyuda consulta)
        {
            try
            {
                await _consultaService.CreateConsulta(consulta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
