using System;

namespace TiendaLibrito.Modelo
{
    public class DetalleCliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaSubscripcion { get; set; }

        public Cliente Cliente { get; set; }
    }
}