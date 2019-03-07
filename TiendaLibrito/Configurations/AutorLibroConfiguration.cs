using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaLibrito.Modelo;

namespace TiendaLibrito.Configurations
{
    class AutorLibroConfiguration : IEntityTypeConfiguration<AutorLibro>
    {
        public void Configure(EntityTypeBuilder<AutorLibro> builder)
        {
            builder.HasKey(a => new { a.IdAutor, a.IdLibro });

            builder.HasOne(a => a.Libro)
                .WithMany(l => l.AutorLibros)
                .HasForeignKey(a => a.IdLibro);

            builder.HasOne(a => a.Autor)
                .WithMany(a => a.AutorLibros)
                .HasForeignKey(a => a.IdAutor);
        }
    }
}
