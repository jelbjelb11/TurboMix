using System.Collections.Generic;

namespace TurboMix
{
    public interface ICategoriaRecetaRepository
    {
        void Crear(CategoriaReceta categoriaReceta);
        void Delete(CategoriaReceta categoriaReceta);
        Receta Read(string nombreCategoriaReceta);
        IList<CategoriaReceta> ShowAll();
        void Update(CategoriaReceta categoriaReceta);
    }
}