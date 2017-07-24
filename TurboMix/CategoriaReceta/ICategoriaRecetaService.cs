namespace TurboMix
{
    public interface ICategoriaRecetaService
    {
        void Actualizar(CategoriaReceta categoriaReceta);
        void Aniadir(CategoriaReceta categoriaReceta);
        void Borrar(CategoriaReceta categoriaReceta);
        void Leer(string categoriaReceta);
        void ListarTodo();
    }
}