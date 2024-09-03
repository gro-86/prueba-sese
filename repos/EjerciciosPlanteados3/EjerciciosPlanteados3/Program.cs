using System.Linq;
using System;
using Microsoft.VisualBasic;
using System.Collections;

namespace EjerciciosPlanteados3
{

    /**
     Joseph-Luis
        Escribe un programa en c#, que almacene las notas de una clase de 10 estudiantes en un array,
        El programa debe realizar las siguientes operaciones
        1- ingreso de notas:
            permitir al usuario ingresar las notas de 10 estudiantes, las notas deben ser numeros enteros entre 0 y 100.
        2-calcular la nota media:
        calcular y mostrar las notas de la clase
        3-maxima y minima nota:
        determinar y mostrar la nota mas alta y la mas baja
        4- notas por encima de la media:
        mostrar las notas que están por encima de la media
        5- ordenar las notas:
        ordenar el array de notas en orden descendiente y mostrar las notas ordenadas
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            int[]notas = new int[10];

            do { 

                Console.WriteLine("=========================================\n");
                Console.WriteLine("\t\tMENU");
                Console.WriteLine("=========================================\n");
                Console.WriteLine("0. Salir\n");
                Console.WriteLine("1. Ingresar nota\n");
                Console.WriteLine("2. Nota media\n");
                Console.WriteLine("3. Máxima y mínima\n");
                Console.WriteLine("4. Notas sobre la media\n");
                Console.WriteLine("5. Ordenar notas (mayor a menor)\n");
                Console.WriteLine("Introduzca un valor entre 0 y 5");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) {

                    case 1:
                        ingresar_nota(ref notas);
                        break;

                    case 2:
                        nota_media(ref notas);
                        break;

                    case 3:
                        nota_max_min(ref notas);
                        break;

                    case 4:
                        nota_sobre_media (ref notas);
                        break;

                    case 5:
                        ordenar_notas(ref notas);
                        break;

                };
                

            } 
            while (opcion!=0);

            Console.WriteLine("¡Que tenga un buen día!");
        }

        static void ingresar_nota(ref int[] notas)
        {
            int nota = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                do
                {

                    try
                    {
                        Console.WriteLine("Introduzca una nota");
                        nota = int.Parse(Console.ReadLine());
                        notas[i] = nota;
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(ex.StackTrace);
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.StackTrace);
                    }

                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.StackTrace);
                    }

                } while (nota < 0 || nota > 100);


            }

        }

        static void nota_media(ref int[] notas)
        {
            int nota = 0;

            for (int i = 0; i < notas.Length; i++)
            {
               
                nota += notas[i];
                Console.WriteLine("Nota {0} = {1}", i + 1, notas[i]);

            }

            Console.WriteLine("Media de las notas {0}", nota/notas.Length);
        }

        static void nota_max_min(ref int[] notas)
        {
            Console.WriteLine("Nota máxima {0}- Nota mímima {1}", notas.Max(), notas.Min());
        }

        static void nota_sobre_media(ref int[] notas)
        {

            for (int i = 0; i < notas.Length; i++)
            {

                if (notas[i] > notas.Average()) {

                    Console.WriteLine("Nota {0} por encima de la media ({1})", notas[i] , notas.Average());

                }

            }
            
        }

        static void ordenar_notas(ref int[] notas)
        {
            ArrayList lista_ordenada = new ArrayList();
            
            for (int i = 0; i < notas.Length; i++)
            {

               lista_ordenada.Add(notas[i]);

            }

            lista_ordenada.Sort();
            lista_ordenada.Reverse();

            foreach (int nota in lista_ordenada) {

                Console.WriteLine("Nota {0} {1}",lista_ordenada.IndexOf(nota)+1, nota);
            
            }

        }

    }
}
