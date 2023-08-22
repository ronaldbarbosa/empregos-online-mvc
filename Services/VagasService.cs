using EmpregosOnLine.Data;
using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpregosOnLine.Services
{
    public class VagasService
    {
        private readonly EmpregosOnLineDbContext _dbContext;

        public VagasService(EmpregosOnLineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Vaga>> GetVagasAsync()
        {
            return await _dbContext.Vagas
                .Include(v => v.Empresa)
                .Include(v => v.Empresa.Endereco)
                .Include(v => v.Habilidades)
                .Include(v => v.Beneficios)
                .ToListAsync();
        }

        public async Task CreateVagaAsync(Vaga vaga)
        {
            await _dbContext.Vagas.AddAsync(vaga);
            await _dbContext.SaveChangesAsync();
        }
    }
}
