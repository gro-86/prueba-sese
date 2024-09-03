using System.Collections;
using System.Xml.Linq;

namespace EjerciciosPlanteados
{

    /**
     
Mostrar al usuario 5 dígitos, cada dígito será un número del 1 al 10 generado aleatoriamente y no se repite ninguno.
Pasados X segundos, los números desaparecen y se mostrarán asteriscos.
Pediremos al usuario que indique en el mismo orden los números que se habían mostrado, separados por un espacio.
Mostrar si ha acertado o no.
Ayuda de código no visto en clase:
// Esperar X segundos
int segundosEspera = 5;
Thread.Sleep(segundosEspera * 1000);

// Limpiar la consola y mostrar asteriscos
Console.Clear();
Console.WriteLine("***** ***** ***** ***** *****");

     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            ArrayList numeros = new ArrayList();
            int cont = 1;
            int valor = -1;
            Timer temporizado;
            string cadena="";
            string cadena2="";
            string cadena3 = "";

            do {

                valor=ran.Next(1, 11);

                if (!numeros.Contains(valor)) { 
                
                    numeros.Add(valor);
                    cont++;
                
                }

            } 

            while (cont<=5);

            foreach (int num in numeros) {

                Console.Write(num+" ");
            
            }

            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine(" *  *  *  *  *");

            try {

                Console.Write("Indique los valores en el siguiente patrón: N N N N N");
                cadena = Console.ReadLine();

            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            }

            for (int x = 0; x < cadena.Length; x++)
            {

                cadena3 += String.Join(" ", cadena[x]);

            }
          
            foreach(int val in numeros) {

                cadena2 += String.Join(" ",val);
            
            }

            string[] vari = cadena.Split(' ');
            string[] vari2 = cadena3.Split(' ');
            int contador = 0;

            for (int x = 0; x < vari.Length; x++)
            {

                if (vari[x] == vari2[x]) {

                    contador++;
              
                }

            }

            if (contador==5)
            {
                Console.WriteLine("HAS ACERTADO");
            }
            else {

                Console.WriteLine("Valor insertado: {0}\nValor esperado : {1}",cadena3,cadena);
            
            }
            
        }

    }
}
