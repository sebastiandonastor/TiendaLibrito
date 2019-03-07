using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaLibrito.Configurations;
using TiendaLibrito.Modelo;

namespace TiendaLibrito.Connection
{
    public class TiendaLibroDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new LibroConfiguration());
            modelBuilder.ApplyConfiguration(new AutorLibroConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new DetalleClienteConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TiendaLibritoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<AutorLibro> AutorLibros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleCliente> DetalleClientes { get; set; }
    }
}
