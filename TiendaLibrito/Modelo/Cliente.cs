using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaLibrito.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DetalleCliente DetalleCliente { get; set; }
    }
}
