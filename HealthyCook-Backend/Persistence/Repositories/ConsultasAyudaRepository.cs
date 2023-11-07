using HealthyCook_Backend.Domain.IRepositories;
using HealthyCook_Backend.Domain.Models;
using HealthyCook_Backend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Persistence.Repositories
{
    public class ConsultasAyudaRepository : IConsultasAyudaRespository
    {
        private readonly AplicationDbContext _context;

        public ConsultasAyudaRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateConsulta(ConsultasAyuda consulta)
        {
            _context.Add(consulta);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ConsultasAyuda>> GetConsultasAyudasByFlag(string flag)
        {
            var consultasAyudas = await _context.Consulta
                .Where(x => x.Flag == flag)
                .ToListAsync();
            return consultasAyudas;
        }

        public async Task<List<ConsultasAyuda>> GetConsultasAyudasByPrioridad(string prioridad)
        {
            var consultasAyudas = await _context.Consulta
                .Where(x => x.Prioridad == prioridad)
                .ToListAsync();
            return consultasAyudas;
        }
    }
}
