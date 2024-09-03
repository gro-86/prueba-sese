using Libreria.Entity;
using Microsoft.EntityFrameworkCore;

namespace Libreria.NewFolder
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=ESPC181415\SQLEXPRESS;Database=DB_Library;User Id=sa;Password=Sese@2024;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la relación 1:N entre Author y Book
            /*ModelBuilder te permite configurar relaciones y entidades*/
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books) //Muchos libros se relacionan con 1 libro
                .WithOne(b => b.Author) //1 libro se relaciona con muchos libros
                .HasForeignKey(b => b.AuthorId); //Especifica la clase foránea para conectar Libro con Autor.

            // Configuración de la relación 1:N entre Publisher y Book
            modelBuilder.Entity<Publisher>()
                .HasMany(p => p.Books) //1 Publicador se relaciona con muchos Libros
                .WithOne(b => b.Publisher)
                .HasForeignKey(b => b.PublisherId);


        }

    }
}
