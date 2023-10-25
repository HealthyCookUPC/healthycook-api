using HealthyCook_Backend.Domain.Models;
using System.Threading.Tasks;
namespace HealthyCook_Backend.Domain.IServices
{
    public interface IConsultasAyudaService
    {
        Task CreateConsulta(ConsultasAyuda consulta);
    }
}
