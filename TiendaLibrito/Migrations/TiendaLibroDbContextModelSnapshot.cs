﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaLibrito.Connection;

namespace TiendaLibrito.Migrations
{
    [DbContext(typeof(TiendaLibroDbContext))]
    partial class TiendaLibroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TiendaLibrito.Modelo.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("TiendaLibrito.Modelo.AutorLibro", b =>
                {
                    b.Property<int>("IdAutor");

                    b.Property<int>("IdLibro");

                    b.HasKey("IdAutor", "IdLibro");

                    b.HasIndex("IdLibro");

                    b.ToTable("AutorLibros");
                });

            modelBuilder.Entity("TiendaLibrito.Modelo.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaPublicacion");

                    b.Property<int>("Stock");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("TiendaLibrito.Modelo.AutorLibro", b =>
                {
                    b.HasOne("TiendaLibrito.Modelo.Autor", "Autor")
                        .WithMany("AutorLibros")
                        .HasForeignKey("IdAutor")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TiendaLibrito.Modelo.Libro", "Libro")
                        .WithMany("AutorLibros")
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
