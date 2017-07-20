namespace TurboMix
{
    public interface ICategoriaRecetaService
    {
        void Actualizar(Receta categoriaReceta);
        void Aniadir(Receta categoriaReceta);
        void Borrar(Receta categoriaReceta);
        void Leer(string categoriaReceta);
        void ListarTodo();
    }
}