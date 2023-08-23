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
            return await _dbContext.Empresas
                .Include(e => e.Endereco)
                .Include(e => e.Vagas)
                .ToListAsync();
        }

        public async Task<Empresa> GetEmpresaAsync(Guid id)
        {
            return await _dbContext.Empresas
                .Include(e => e.Endereco)
                .Include(e => e.Vagas)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateEmpresaAsync(Empresa empresa)
        {
            await _dbContext.Empresas.AddAsync(empresa);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateEmpresaAsync(Empresa empresa)
        {
            var endereco = empresa.Endereco;
            _dbContext.Enderecos.Update(endereco);
            _dbContext.Empresas.Update(empresa);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEmpresaAsync(Empresa empresa)
        {
            var endereco = await _dbContext.Enderecos.FindAsync(empresa.EnderecoId);
            if (endereco != null) 
            {
                _dbContext.Enderecos.Remove(endereco);
            }
            _dbContext.Empresas.Remove(empresa);
            await _dbContext.SaveChangesAsync();
        }
    }
}
