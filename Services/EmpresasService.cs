using EmpregosOnLine.Data;
using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpregosOnLine.Services
{
    public class EmpresasService
    {
        private readonly EmpregosOnLineDbContext _dbContext;

        public EmpresasService(EmpregosOnLineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Empresa>> GetEmpresasAsync()
        {
            return await _dbContext.Empresas.Include(e => e.Endereco).ToListAsync();
        }

        public async Task CreateEmpresaAsync(Empresa empresa)
        {
            await _dbContext.AddAsync(empresa);
            await _dbContext.SaveChangesAsync();
        }
    }
}
