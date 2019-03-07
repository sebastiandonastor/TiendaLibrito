using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaLibrito.Modelo;

namespace TiendaLibrito.Configurations
{
    public class DetalleClienteConfiguration : IEntityTypeConfiguration<DetalleCliente>
    {
        public void Configure(EntityTypeBuilder<DetalleCliente> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(d => d.Cliente)
                .WithOne(c => c.DetalleCliente)
                .HasForeignKey<DetalleCliente>(d => d.IdCliente);

        }
    }
}
