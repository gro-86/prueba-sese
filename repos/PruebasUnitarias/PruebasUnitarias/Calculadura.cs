using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    public class Calculadura
    {

        public static int sumar(int x, int y) {


                return x + y;
            
         
        
        }

        public static int restar(int x, int y)
        {

            if (x == 0)
            {

                return 0;
            }
            else
            {

                return x - y;

            }

        }

        public static int dividir(int x, int y)
        {

            if (y == 0)
            {

                return 0;
            }
            else
            {

                return x / y;

            }

        }

        public static int multiplicar(int x, int y)
        {

            if (x == 0)
            {

                return 0;
            }
            else
            {

                return x * y;

            }

        }

        public static bool par(int x)
        {

            if (x == 0)
            {

                return false;
            }
            else if (x % 2 == 0)
            {



                return true;

            }
            else {


                return false;
            }

        }

        public static bool nulo(string texto)
        {

            if (x == 0)
            {

                return false;
            }
            else if (x % 2 == 0)
            {



                return true;

            }
            else
            {


                return false;
            }

        }

    }
}
