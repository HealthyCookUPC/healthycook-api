using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
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
        
        [Route("GetConsultasAyudasByFlag/{flag}")]
        [HttpGet]
        public async Task<IActionResult> GetConsultasAyudasByFlag(string flag)
        {
            try
            {
                var consultaAyudaList = _consultaService.GetConsultasAyudasByFlag(flag);
                return Ok(consultaAyudaList);
            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("GetConsultasAyudasByPrioridad/{prioridad}")]
        [HttpGet]
        public async Task<IActionResult> GetConsultasAyudasByPrioridad(string prioridad)
        {
            try
            {
                var consultaAyudaList = _consultaService.GetConsultasAyudasByPrioridad(prioridad);
                return Ok(consultaAyudaList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
