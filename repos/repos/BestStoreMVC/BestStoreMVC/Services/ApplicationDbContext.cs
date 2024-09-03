using BestStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Services
{

    /**
    Esta clase te permite conectar con la base de datos usando Entity.Framework
    Es un servicio que tendrá que ser usado por otras clases.
 */
    public class ApplicationDbContext: DbContext
    {
        //Constructor con parámetro DbContextOptions. Se pasa a la clase base
        //Se pasa la clase al contenedor de servicio de la app (Program.cs).
        public ApplicationDbContext(DbContextOptions options) : base(options) {
        
        }

        //Se añade a la clase para poder añadir una clase Product en la base de datos
        public DbSet<Product> Products { get; set; }

        /**
         Creamos un archivo de migración en la consola del programa (busca en Ver - Otras Ventanas - Package Manager Console - Consola del Administrador de Paquetes).
        Add-Migration [el nombre del archivo a crear] esto se almacena en la carpeta Migrations
        para poder llevar la clase a la base de datos.

        Después actualizamos la base de datos para poder crear la clase Products: Update-Database.
        Actualiza en la interfaz de las bases de datos para que veas las columnas en Products.

         */
    }
}
