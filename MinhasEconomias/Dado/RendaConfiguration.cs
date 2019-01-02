using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhasEconomias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasEconomias.Dado
{
    public class RendaConfiguration : IEntityTypeConfiguration<Renda>
    {
        public void Configure(EntityTypeBuilder<Renda> builder)
        {

            builder
                .ToTable("Renda");

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
