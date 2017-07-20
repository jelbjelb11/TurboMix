using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class CategoriaRecetaRepository : ICategoriaRecetaRepository
    {
        private IList<CategoriaReceta> listaCategoriaRecetas = new List<CategoriaReceta>();

        public void Crear(CategoriaReceta categoriaReceta)
        {
            listaCategoriaRecetas.Add(categoriaReceta);
        }

        public Receta Read(String nombreCategoriaReceta)
        {
            Receta receta = new Receta();
            receta.nombre = nombreCategoriaReceta;
            return receta;
        }

        public IList<CategoriaReceta> ShowAll()
        {
            //TODO

            return listaCategoriaRecetas;
        }

        public void Update(CategoriaReceta categoriaReceta)
        {
            //TODO
        }

        public void Delete(CategoriaReceta categoriaReceta)
        {
            //TODO
        }
    }
}

