using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class CategoriaReceta
    {
        public String nombre { get; set; }
        public String descripcion { get; set; }

        public CategoriaReceta() { }
        public CategoriaReceta(String nombre, String descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
