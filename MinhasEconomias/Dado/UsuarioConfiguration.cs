using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhasEconomias.Models;
using System;

namespace MinhasEconomias
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .ToTable("Usuario");

            builder
                .Property(x => x.Id)
                .HasColumnName("Id");

            builder
                .Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(x => x.CPF)
                .HasColumnName("CPF")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder
                .Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(100)")
                .IsRequired();

        }
    }
}
