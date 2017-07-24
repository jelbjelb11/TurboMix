namespace TurboMix
{
    public interface ICategoriaRecetaRepository
    {
        void Crear(CategoriaReceta categoriaReceta);
        void Delete(CategoriaReceta categoriaReceta);
        CategoriaReceta Read(CategoriaReceta categoriaReceta);
        void ShowAll();
        void Update(CategoriaReceta categoriaReceta, string nombre, string descripcion);
    }
}