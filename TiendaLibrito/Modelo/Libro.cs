using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaLibrito.Modelo
{
    public class Libro
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public List<AutorLibro> AutorLibros { get; set; }
        public List<Factura> Facturas { get; set; }

    }
}
