namespace Libreria.Entity
{
    public class Publisher
    {

        public int PublisherId { get; set; }
        public string Name { get; set; }

        // Relación 1 a N: Un editor tiene muchos libros
        public ICollection<Book> Books { get; set; }

    }
}
