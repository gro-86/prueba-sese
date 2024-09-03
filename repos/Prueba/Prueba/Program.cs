using System;
using System.Linq.Expressions;

namespace Program {
    internal static class Program {
        static void Main(string[] args) {

            int cantidad=-1;
            int menu1=-1;
            int menu2=-1;
            Random ran = new Random();
            int vida = ran.Next(1,101);
            int economia = ran.Next(1, 101);
            int religion = ran.Next(1, 101);
            int carisma = ran.Next(1, 101);
            int felicidad = ran.Next(1, 101);

            //Console.WriteLine("\n\n\n[[ Valores iniciales ]] \nVida ==> {0}\nEconomia ==> {1}\nReligion ==> {2}\nCarisma ==> {3}\nFelicidad ==> {4}" ,vida, economia, religion, carisma, felicidad);

            do {

                Console.WriteLine("\n=============================");
                Console.WriteLine("=---         MENU        ---=");
                Console.WriteLine("=============================\n");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Vida");
                Console.WriteLine("2. Economia");
                Console.WriteLine("3. Religion");
                Console.WriteLine("4. Carisma");
                Console.WriteLine("5. Felicidad");

                Console.WriteLine("Elija una opción: ");

                try{

                    menu1 = int.Parse(Console.ReadLine());

                }catch(FormatException ex) {

                    Console.WriteLine(ex.Message);

                }catch (Exception ex) {

                    Console.WriteLine(ex.Message);

                }

                do {

                    Console.WriteLine("\n==============================");
                    Console.WriteLine("=---       OPERACION      ---=");
                    Console.WriteLine("==============================\n");
                    Console.WriteLine("0. Salir");
                    Console.WriteLine("1. Aumentar");
                    Console.WriteLine("2. Reducir");
                    Console.WriteLine("Elija una opción: ");

                    try{

                        menu2 = int.Parse(Console.ReadLine());

                    }catch (FormatException ex){

                        Console.WriteLine(ex.Message);

                    }catch (Exception ex){

                        Console.WriteLine(ex.Message);

                    }

                    switch (menu2) {

                        case 1:

                            try{
                            Console.WriteLine("Elija una cantidad: ");


                            cantidad = int.Parse(Console.ReadLine());

                            }catch (FormatException ex){

                                Console.WriteLine(ex.Message);

                            }catch (Exception ex){

                                Console.WriteLine(ex.Message);

                            }

                            switch (menu1) {

                                case 1:

                                    vida += cantidad;
                                    Console.WriteLine("Vida total = {0}", vida);
                                    break;

                                case 2:

                                    economia += cantidad;
                                    Console.WriteLine("Economía total = {0}", economia);
                                    break;

                                case 3:

                                    religion += cantidad;
                                    Console.WriteLine("Religion total = {0}", religion);
                                    break;

                                case 4:

                                    carisma += cantidad;
                                    Console.WriteLine("Carisma total = {0}", carisma);
                                    break;


                                case 5:

                                    felicidad += cantidad;
                                    Console.WriteLine("Felicidad total = {0}", felicidad);
                                    break;

                                default:

                                    Console.WriteLine("Opción inválida");
                                    break;
                            }

                            break;

                        case 2:

                            try {

                                Console.WriteLine("Elija una cantidad: ");
                                cantidad = int.Parse(Console.ReadLine());

                            } catch (FormatException ex) {

                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex){

                                Console.WriteLine(ex.Message);

                            }

                            switch (menu1) {

                                case 1:

                                    if ((cantidad - vida) > 0) {

                                        vida -= cantidad;
                                        Console.WriteLine("Vida total = {0}", vida);

                                    }else {

                                        menu1 = 0;
                                        menu2 = 0;

                                    }

                                    break;

                                case 2:

                                    if ((cantidad - economia) > 0) {

                                        economia -= cantidad;
                                        Console.WriteLine("Economía total = {0}", economia);


                                    }else {

                                        menu1 = 0;
                                        menu2 = 0;

                                    }

                                    break;

                                case 3:

                                    if ((cantidad - religion) > 0) {

                                        religion -= cantidad;
                                        Console.WriteLine("Religión total = {0}", religion);

                                    }else {

                                        menu1 = 0;
                                        menu2 = 0;
                                    }


                                    break;

                                case 4:

                                    if ((cantidad - carisma) > 0) {

                                        carisma -= cantidad;
                                        Console.WriteLine("Carisma total = {0}", carisma);


                                    } else {

                                        menu1 = 0;
                                        menu2 = 0;

                                    }

                                    break;

                                case 5:

                                    if ((cantidad - felicidad) > 0) {

                                        felicidad -= cantidad;
                                        Console.WriteLine("Felicidad total = {0}", felicidad);

                                    
                                    }else {

                                        menu1 = 0;
                                        menu2 = 0;

                                    }

                                    break;

                            }

                        break;

                    }

                } while (menu2 > 0);

            } while (menu1 > 0);

            Console.WriteLine("¡¡Que tenga un buen día!!");

        }

    }

}
