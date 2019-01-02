using Microsoft.EntityFrameworkCore;
using MinhasEconomias.Dado;
using MinhasEconomias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasEconomias
{
    public class EnonomiasContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Renda> Rendas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MySavin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RendaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
