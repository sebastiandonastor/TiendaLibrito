using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaLibrito.Modelo
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public DateTime FechaExpedicion { get; set; }

        public List<Factura> Facturas { get; set; }
    }
}
