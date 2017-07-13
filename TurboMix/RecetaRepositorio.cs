using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    class RecetaRepositorio
    {
        public List<Receta> listaRecetas { get; set; }

        public RecetaRepositorio() { }
        public RecetaRepositorio(List<Receta> listaRecetas)
        {
            this.listaRecetas = listaRecetas;
        }

    }
}
