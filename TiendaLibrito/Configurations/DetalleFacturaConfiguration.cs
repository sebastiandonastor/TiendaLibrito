using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaLibrito.Modelo;

namespace TiendaLibrito.Configurations
{
    class DetalleFacturaConfiguration : IEntityTypeConfiguration<DetalleFactura>
    {
        public void Configure(EntityTypeBuilder<DetalleFactura> builder)
        {
            builder.HasKey(d => d.Id);
        }
    }
}
