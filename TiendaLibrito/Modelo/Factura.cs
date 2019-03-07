using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaLibrito.Modelo
{
    public class Factura
    {
        public int IdLibro { get; set; }
        public int IdCliente { get; set; }
        public int IdDetalleFactura { get; set; }
        public int Cantidad { get; set; }


        public Libro Libro { get; set; }
        public DetalleFactura DetalleFactura { get; set; }
        public Cliente Cliente { get; set; }

    }
}
