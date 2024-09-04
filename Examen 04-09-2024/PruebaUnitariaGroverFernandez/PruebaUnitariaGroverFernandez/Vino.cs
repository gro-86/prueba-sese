namespace PruebaUnitariaGroverFernandez
{
    public class Vino
    {

        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Vino(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Vino: {Nombre}");
            Console.WriteLine($"Tipo: {Tipo}");
        }


    }
}
