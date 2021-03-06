﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinhasEconomias;

namespace MinhasEconomias.Migrations
{
    [DbContext(typeof(EnonomiasContext))]
    [Migration("20181110234410_MyEconomia")]
    partial class MyEconomia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MinhasEconomias.Models.Despesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("Periodo");

                    b.Property<int?>("UsuarioId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("MinhasEconomias.Models.Renda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("Periodo")
                        .HasColumnName("Periodo")
                        .HasColumnType("datetime");

                    b.Property<int?>("UsuarioId");

                    b.Property<decimal>("Valor")
                        .HasColumnName("Valor")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Renda");
                });

            modelBuilder.Entity("MinhasEconomias.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnName("CPF")
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MinhasEconomias.Models.Despesa", b =>
                {
                    b.HasOne("MinhasEconomias.Models.Usuario", "Usuario")
                        .WithMany("Despesas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("MinhasEconomias.Models.Renda", b =>
                {
                    b.HasOne("MinhasEconomias.Models.Usuario", "Usuario")
                        .WithMany("Rendas")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
