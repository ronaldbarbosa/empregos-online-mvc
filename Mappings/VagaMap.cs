using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpregosOnLine.Mappings
{
    public class VagaMap : IEntityTypeConfiguration<Vaga>
    {
        public void Configure(EntityTypeBuilder<Vaga> builder)
        {
            builder.Property(v => v.Titulo)
                .HasColumnType("varchar(50)");

            builder.Property(v => v.Descricao)
                .HasColumnType("varchar(150)");

            builder.Property(v => v.Salario)
                .HasColumnType("decimal(10, 2)");

            builder.HasOne(v => v.Empresa)
                .WithMany(e => e.Vagas)
                .HasForeignKey(e => e.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(v => v.Beneficios)
                .WithMany(b => b.Vagas)
                .UsingEntity(j => j.ToTable("VagaBeneficio"));

            builder.HasMany(v => v.Habilidades)
                .WithMany(h => h.Vagas)
                .UsingEntity(j => j.ToTable("VagaHabilidade"));
        }
    }
}
