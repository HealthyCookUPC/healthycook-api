using HealthyCook_Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IRepositories
{
    public interface IConsultasAyudaRespository
    {
        Task CreateConsulta(ConsultasAyuda consulta);
        Task<List<ConsultasAyuda>> GetConsultasAyudasByFlag(string flag);
        Task<List<ConsultasAyuda>> GetConsultasAyudasByPrioridad(string prioridad);
    }
}
