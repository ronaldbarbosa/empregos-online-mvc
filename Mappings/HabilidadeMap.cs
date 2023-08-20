using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpregosOnLine.Mappings
{
    public class HabilidadeMap : IEntityTypeConfiguration<Habilidade>
    {
        public void Configure(EntityTypeBuilder<Habilidade> builder)
        {
            builder.Property(h => h.Titulo)
                .HasColumnType("varchar(30)");

            builder.HasData(
                new Habilidade("C#"),
                new Habilidade("HTML"),
                new Habilidade("CSS"),
                new Habilidade("Javascript"),
                new Habilidade("JQuery"),
                new Habilidade("Bootstrap"),
                new Habilidade("ASP.NET Core"),
                new Habilidade("Entity Framework Core"),
                new Habilidade("SQL Server")
            );
        }
    }
}
