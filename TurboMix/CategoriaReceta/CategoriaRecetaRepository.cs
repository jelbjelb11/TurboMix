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

        public CategoriaReceta Read(CategoriaReceta categoriaReceta)
        {
            foreach (CategoriaReceta c in listaCategoriaRecetas)
            {
                return c;
            }
            return null;
        }

        public void ShowAll()
        {

            foreach (CategoriaReceta c in listaCategoriaRecetas)
                if (c != null)
                    System.Console.WriteLine(c.nombre + ":" + c.descripcion);
                else
                    System.Console.WriteLine("Elemento vacío.");
        }

        public void Update(CategoriaReceta categoriaReceta, String nombre, String descripcion)
        {
            categoriaReceta.nombre = nombre;
            categoriaReceta.descripcion = descripcion;
        }

        public void Delete(CategoriaReceta categoriaReceta)
        {
            listaCategoriaRecetas.Contains<categoriaReceta>;
        }
    }
}

