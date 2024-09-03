namespace Libreria
{
    public interface IGestor<T>
    {
        void agregar(T item);
        void eliminar(T item);
        T buscar(int id);
        void actualizar(T item);
        IEnumerable<T> buscarTodos();
    }
}
