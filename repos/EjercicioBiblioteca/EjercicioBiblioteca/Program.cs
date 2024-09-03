namespace EjercicioBiblioteca
{
    internal class Program
    {

        /**
         En el mÃ©todo Main del programa:
Crear instancias de Libro, Revista, y DVD.
Asignar valores a sus propiedades.
Llamar al mÃ©todo MostrarInformacion para cada una de las instancias para mostrar su informaciÃ³n en la consola.
         */
        static void Main(string[] args)
        {
            DVD dvd1 = new DVD("Midsommar","Ari Aster",2020,"Le Creepy",129);
            Libro libro1 = new Libro("TaMakuende Yaya","Lydia Cabrera", 1978,"LoSorbo",320);
            Revista revista1 = new Revista("Le trip","Terence Mckenna",2000,"Golden T",4);

            Console.WriteLine(dvd1.ToString());
            Console.WriteLine(dvd1.mostrar_tipo_material());
            Console.WriteLine(dvd1.mostrar_estado_material());
            Console.WriteLine(libro1.ToString());
            Console.WriteLine(libro1.esta_asegurado());
            Console.WriteLine(libro1.mostrar_tipo_seguridad());
            Console.WriteLine(libro1.mostrar_tipo_material());
            Console.WriteLine(libro1.mostrar_estado_material());
            Console.WriteLine(revista1.ToString());
            Console.WriteLine(revista1.mostrar_tipo_material());
            Console.WriteLine(revista1.mostrar_estado_material());

        }
    }
}
