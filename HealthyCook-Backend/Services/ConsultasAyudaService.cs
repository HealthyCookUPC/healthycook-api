using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.IServices;
using HealthyCook_Backend.Domain.Models;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Services
{
    public class ConsultasAyudaService : IConsultasAyudaService

    {
        private readonly IConsultasAyudaRespository _consultaRepository;
        public ConsultasAyudaService(IConsultasAyudaRespository consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }

        public async Task CreateConsulta(ConsultasAyuda consulta)
        {
            await _consultaRepository.CreateConsulta(consulta);
        }
    }
}
