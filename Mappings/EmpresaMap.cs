using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpregosOnLine.Mappings
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.Property(e => e.Nome)
                .HasColumnType("varchar(30)");
            builder.Property(e => e.NomeFantasia)
                .HasColumnType("varchar(30)");
            builder.Property(e => e.CNPJ)
                .HasColumnType("varchar(20)");
            builder.Property(e => e.UrlImagem)
                .HasColumnType("varchar(256)");
        }
    }
}
