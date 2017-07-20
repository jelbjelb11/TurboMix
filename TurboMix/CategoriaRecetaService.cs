using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    class CategoriaRecetaService : ICategoriaRecetaService
    {
        public ICategoriaRecetaRepository categoriaRecetaRepository { get; set; }

        public CategoriaRecetaService(ICategoriaRecetaRepository _categoriaRecetaRepository)
        {
            this.categoriaRecetaRepository = _categoriaRecetaRepository;
        }

        public void Aniadir(Receta categoriaReceta)
        {
            categoriaRecetaRepository.Crear(categoriaReceta);
        }

        public void Leer(String categoriaReceta)
        {
            categoriaRecetaRepository.Read(categoriaReceta);
        }

        public void Actualizar(Receta categoriaReceta)
        {
            categoriaRecetaRepository.Update(categoriaReceta);
        }

        public void Borrar(Receta categoriaReceta)
        {
            categoriaRecetaRepository.Delete(categoriaReceta);
        }

        public void ListarTodo()
        {
            categoriaRecetaRepository.ShowAll();
        }
    }
}
