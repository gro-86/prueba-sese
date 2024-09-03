namespace Libreria.Entity
{
    public class Author
    {

        public int AuthorId { get; set; }
        public string Name { get; set; }

        // Relación 1 a N: Un autor tiene muchos libros
        public ICollection<Book> Books { get; set; }

    }
}
