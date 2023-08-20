using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpregosOnLine.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.CEP)
                .HasColumnType("varchar(11)");
            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(100)");
            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(50)");
            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(100)");
            builder.Property(e => e.Cidade)
                .HasColumnType("varchar(30)");
            builder.Property(e => e.Estado)
                .HasColumnType("varchar(30)");
        }
    }
}
