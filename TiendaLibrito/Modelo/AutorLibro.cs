using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaLibrito.Modelo
{
    public class AutorLibro
    {
        public int IdAutor { get; set; }
        public int IdLibro { get; set; }

        public Autor Autor { get; set; }
        public Libro Libro { get; set; }

    }
}
