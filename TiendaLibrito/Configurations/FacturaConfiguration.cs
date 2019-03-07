using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaLibrito.Modelo;

namespace TiendaLibrito.Configurations
{
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.HasKey(f => new { f.IdCliente, f.IdLibro, f.IdDetalleFactura });

            builder.HasOne(b => b.Cliente)
            .WithMany(c => c.Facturas)
            .HasForeignKey(b => b.IdCliente);

            builder.HasOne(b => b.Libro)
                .WithMany(l => l.Facturas)
                .HasForeignKey(b => b.IdLibro);

            builder.HasOne(b => b.DetalleFactura)
                .WithMany(d => d.Facturas)
                .HasForeignKey(b => b.IdDetalleFactura);


        }
    }
}
