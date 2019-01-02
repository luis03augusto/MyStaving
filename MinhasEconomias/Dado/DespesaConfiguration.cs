using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhasEconomias.Models;
using System;

namespace MinhasEconomias.Dado
{
    public class DespesaConfiguration : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder
                .ToTable("Despesa");

            builder
               .Property(x => x.Id)
               .HasColumnName("id");

            builder
               .Property(x => x.Descricao)
               .HasColumnName("Descricao")
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder
               .Property(x => x.Valor)
               .HasColumnName("Valor")
               .HasColumnType("decimal");

            builder
                .Property(x => x.Periodo)
                .HasColumnName("Periodo")
                .HasColumnType("datetime");

        }
    }
}
