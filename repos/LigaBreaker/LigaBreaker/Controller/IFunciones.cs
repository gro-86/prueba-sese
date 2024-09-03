
namespace BreakingLeague.Controller
{
    internal interface IFunciones<T>
    {
        public void create(T item);

        public void delete(T item);

        public T searchById(int id);

        public IEnumerable<T> selectAll();

        public void update(T item);

    }
}
