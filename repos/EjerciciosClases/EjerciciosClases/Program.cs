namespace EjerciciosClases
{
    internal class Program
    {

        /**
         Pelicula: titulo, director, duracion (minutos), año de estreno.
        Medoto devolver edad (año actual y de estreno).
        Cada peli tiene sus calificaciones (array de enteros del 0 al 5).

        Crea varias pelis con algunas calificaciones.
        Imprime detalles y el promedio de notas.
         */
        static void Main(string[] args)
        {
           

            Pelicula peli1 = new Pelicula("Midsommar","Ari Aster",120.30,DateTime.Parse("2023-01-01"));
            Pelicula peli2 = new Pelicula("Hereditary", "Ari Aster", 135, DateTime.Parse("2001-11-03"));

            Console.WriteLine("\n==================================");

            Console.WriteLine(peli1.ToString());
            peli1.rellenar_calificaciones();       
            peli1.edad_actual();
            peli1.ToString2();
            peli1.promedio();
            

            Console.WriteLine("==================================\n");

            Console.WriteLine(peli2.ToString());
            peli2.rellenar_calificaciones();
            peli2.edad_actual();
            peli2.ToString2();
            peli2.promedio();
            

        }

    }
}
