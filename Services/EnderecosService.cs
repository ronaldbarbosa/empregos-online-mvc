using EmpregosOnLine.Data;
using EmpregosOnLine.Models;

namespace EmpregosOnLine.Services
{
    public class EnderecosService
    {
        private readonly EmpregosOnLineDbContext _dbContext;

        public EnderecosService(EmpregosOnLineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateEnderecoAsync(Endereco endereco)
        {
            await _dbContext.Enderecos.AddAsync(endereco);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Endereco> GetEnderecoAsync(Guid id)
        {
            return await _dbContext.Enderecos.FindAsync(id);
        }
    }
}
