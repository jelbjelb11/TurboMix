using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    class Aviso
    {
        public int id { get; set; }
        public int criticidad { get; set; }
        public DateTime fecha { get; set; }

        public Aviso() { }
        public Aviso(int id, int criticidad, DateTime fecha)
        {
            this.id = id;
            this.criticidad = criticidad;
            this.fecha = fecha;
        }
    }
}
