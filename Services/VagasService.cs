﻿using EmpregosOnLine.Data;
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

        public async Task<Vaga?> GetVagaAsync(Guid id)
        {
            return await _dbContext.Vagas
                .Include(v => v.Empresa)
                .Include(v => v.Empresa.Endereco)
                .Include(v => v.Habilidades)
                .Include(v => v.Beneficios)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateVagaAsync(Vaga vaga)
        {
            await _dbContext.Vagas.AddAsync(vaga);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateVagaAsync(Vaga vaga)
        {
            _dbContext.Vagas.Update(vaga);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveVagaAsync(Guid id)
        {
            var vaga = await _dbContext.Vagas.FindAsync(id);
            if (vaga != null) 
            {
                _dbContext.Vagas.Remove(vaga); 
                _dbContext.SaveChanges();
            }
        }
    }
}
