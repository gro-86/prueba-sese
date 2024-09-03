namespace EjerciciosPropuestos2_Ser_Tom
{

    /**
            Vamos a crear una clase vehículo, y dentro de ella crear un hashset llamado garaje que almacena vehículos. 
    Creamos un un menú por el cual se puede crear un vehículo (opción 1), (opción 2) borrar vehículo y (opción 3) mostrar el garaje. 
    El vehículo creado tendrá las siguientes propiedades: matricula, tipo, modelo, marca, todas de tipo cadena (string).
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            Garaje gar1 = new Garaje();
            Vehiculo vehiculo;
            string mat, mod, tip, mar;

            do {

                Console.WriteLine("\n==================================");
                Console.WriteLine("\tMENU");
                Console.WriteLine("\n==================================");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Crear vehículo");
                Console.WriteLine("2. Borrar vehículo");
                Console.WriteLine("3. Mostrar garaje");

                try
                {
                    Console.WriteLine("\nInserte un valor");
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex) { 
                
                    Console.WriteLine(ex.Message);
                
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }

                switch (opcion)
                {

                    case 0:

                        Console.WriteLine("¡¡Que tenga un buen día!!");

                        break;

                    case 1:

                        do

                        Console.WriteLine("\nInserte una matrícula");
                        mat = Console.ReadLine();

                        Console.WriteLine("\nInserte un modelo");
                        mod = Console.ReadLine();

                        Console.WriteLine("\nInserte un tipo");
                        tip = Console.ReadLine();

                        Console.WriteLine("\nInserte una marca");
                        mar = Console.ReadLine();

                        vehiculo = new Vehiculo(mat, tip, mod, mar);
                        gar1.Vehiculos.Add(vehiculo);

                        break;

                    case 2:

                        if (gar1.Vehiculos.Count == 0)
                        {

                            Console.WriteLine("\nGaraje vacío. El vehículo no existe");

                        }
                        else
                        {

                            Console.WriteLine("Inserte una matrícula");
                            mat = Console.ReadLine();
                            bool borrado = false;

                            foreach (Vehiculo ve in gar1.Vehiculos) {

                                if (ve.Matricula == mat) {

                                    gar1.Vehiculos.Remove(ve);
                                    borrado = true;

                                }

                            }

                            if (borrado == true)
                            {

                                Console.WriteLine("Vehículo borrado.");

                            }
                            else {

                                Console.WriteLine("\nEl vehículo no existe.");

                            }

                        }

                        break;

                    case 3:

                        if (gar1.Vehiculos.Count == 0)
                        {

                            Console.WriteLine("\nGaraje vacío");

                        }
                        else {

                            Console.WriteLine("--------------------------------------");
                            foreach (Vehiculo ve in gar1.Vehiculos)
                            {

                                Console.WriteLine("\n[ Vehículo ]\n" + ve.ToString());

                            }
                            Console.WriteLine("--------------------------------------");

                        }

                        break;

                }

            } while (opcion!=0);
        }
    }
}
