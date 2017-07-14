using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class RecetaRepository : IRecetaRepository
    {
//        public List<Receta> listaRecetas { get; set; }
        private IList<Receta> listaRecetas = new List<Receta>();

        //public RecetaRepository() { }
        //public RecetaRepository(List<Receta> listaRecetas)
        //{
        //    this.listaRecetas = listaRecetas;
        //}

        public void Crear(Receta receta)
        {
            listaRecetas.Add(receta);
        }
    }
}
