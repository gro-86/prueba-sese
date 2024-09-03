using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 Se crea un número con la función random de entre 1 y 50 de forma interna. 
El programa tiene que indicar "mayor" y "menor" según el número que escoja el usuario. 
El usuario tiene que adivinarlo con un máximo de 5 oportunidades.
 */

namespace EjerciciosPlanteados
{
    internal class Program2
    {

        static void Main(string[] args)
        {

            Random ran = new Random();
            int num = ran.Next(1, 51);
            int numero = -1;
            Console.WriteLine("N {0}",num);

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Escriba un número");
                numero = int.Parse(Console.ReadLine());

                if (numero == num)
                {

                    Console.WriteLine("Número acertado {0}", num);
                    break;
                }
                else {

                    Console.WriteLine("Número acertado equivocado");

                }

            }

        }

        

    }
}
