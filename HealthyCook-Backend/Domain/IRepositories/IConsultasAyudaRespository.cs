using HealthyCook_Backend.Domain.Models;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IRepositories
{
    public interface IConsultasAyudaRespository
    {
        Task CreateConsulta(ConsultasAyuda consulta);
    }
}
