namespace EjerciciosPlanteados2
{
    internal class Program
    {
        

/**
 Se crea un número con la función random de entre 1 y 50 de forma interna. 
El programa tiene que indicar "mayor" y "menor" según el número que escoja el usuario. 
El usuario tiene que adivinarlo con un máximo de 5 oportunidades.
 */


            static void Main(string[] args)
            {

                Random ran = new Random();
                int num = ran.Next(1, 51);
                int numero = -1;
                bool existe = false;
                Console.WriteLine("N {0}", num);

                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine("Escriba un número");
                    numero = int.Parse(Console.ReadLine());

                    if (numero == num)
                    {

                        Console.WriteLine("Número acertado {0}", num);
                        existe = true;
                        break;
                    }
                    else
                    {

                        Console.WriteLine("Número equivocado");

                    }

                }

            if (existe == false)
            {
                Console.WriteLine("QUE TENGA UN BUEN DIA");
            }

            }

        }
    }

