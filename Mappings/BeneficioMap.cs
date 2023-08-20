using EmpregosOnLine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpregosOnLine.Mappings
{
    public class BeneficioMap : IEntityTypeConfiguration<Beneficio>
    {
        public void Configure(EntityTypeBuilder<Beneficio> builder)
        {
            builder.Property(b => b.Titulo)
                .HasColumnType("varchar(20)");

            builder.HasData(
                new Beneficio("Vale alimentação"),
                new Beneficio("Vale refeição"),
                new Beneficio("Gympass"),
                new Beneficio("PLR"),
                new Beneficio("Vale combustível")
            );
        }
    }
}
