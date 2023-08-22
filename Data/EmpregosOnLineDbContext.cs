//using EmpregosOnLine.Mappings;
using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EmpregosOnLine.Models.ViewModels;

namespace EmpregosOnLine.Data
{
    public class EmpregosOnLineDbContext : DbContext
    {
        public EmpregosOnLineDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new VagaMap());
            //modelBuilder.ApplyConfiguration(new EnderecoMap());
            //modelBuilder.ApplyConfiguration(new HabilidadeMap());
            //modelBuilder.ApplyConfiguration(new BeneficioMap());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
    }
}
