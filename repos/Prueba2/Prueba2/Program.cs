using System;

namespace Prueba2 {
    internal class Program {
        static void Main(string[] args) {

            int cantidad = -1;
            int menu1 = -1;
            int menu2 = -1;
            Random ran = new Random();
            int salud = ran.Next(1, 101);
            int economia = ran.Next(1, 101);
            int religion = ran.Next(1, 101);
            int carisma = ran.Next(1, 101);
            int felicidad = ran.Next(1, 101);
            int valentia = ran.Next(1, 101);
            Boolean action = false;

            string[] preguntas = { 

                "Un guardia borracho y enaltecido intenta arrebatar las pertenencias a un ciudadano indefenso. ¿Qué decides?\n1.Huyes como un condenado.\n2.Intentas hacerle recapacitar.\n3.Decides enfrentarte a él.", 
                "Te encuentras al cura del pueblo:\n1.Decides pedirle asesoramiento espiritual\n2.Haces una donación para la parroquia.\n3.Decides ignorarle.",
                "Ves a lo lejos a Gala (la dama que por la que bebes los vientos). ¿Qué haces?\n1.Pasas de ella. La RedPill mola más.\n2.Le echas un par y te acercas a ella.\n3.Soy virgo. Tengo miedo.",
                "Ves al loco de la comarca (que casualmente es tu colega) haciendo el ridículo mientras crea un gran revuelo a su alrededor. ¿Qué haces?\n1.Pasas de que te vean con ese freak.\n2.Le sacas del apunto a expensas de que tu imagen se pueda ver dañada\n3.A la m*****a todo. Quieres echarte unas risas",
                "Te planteas algo más en la vida. No quieres ir fangando a la gente. ¿Qué haces?\n1.Pensar en el futuro es de pringlers. Me gusta el dinero fácil.\n2.Soy ambicioso. Quieres aprender el oficio de la forja.\n3.Te apuntas al seminario del pueblo. Al menos tendrás un cuenco de caldo garantizado.",
                "Estás enfermo y necesitas recursos para comprar medicinas. ¿Qué haces?\n1.Pides un par de pesetas prestadas a la familia/amigos.\n2.Decides organizar a un par de bandoleros y planeas un golpe en palacete del duque de Pastizal.\n3.Trabajarás dignamente y con suerte consigas el dinero en 1 año.",
                "Tienes tiempo libre. ¿Qué haces?\n1.Haces una visita a tus colegas, los mataos.\n2.Vas a buscar pegamento. La vida es una m...\n3.La vida del mangante es muy sacrificada. Necesitas estar descansado para correr mejor.",
                "Tienes un mendrugo de pan mohoso, pero es comida... ¿Qué haces con él?\n1. Lo vendes para conseguir un poco de money.\n2.Te lo comes, no sabes cuándo vas a poder volver a comer.\n3.Se lo das tu colega de fechorías (Elmaki)",
                "Estás todo cocido en la taberna hedionda del barrio. La cosa se está poniendo candente porque otro drojas te está desafiando. ¿Qué haces?\n1.Aplicar la ley rumana (A mí nadie me toca los c......s).\n2.",
                "Ana",
                "Pedro",
                "María"

            };

            int anyo = ran.Next(ran.Next(924, 1101), ran.Next(1101, 1824)+1); 
            int mes = ran.Next(1, 13);
            int dia = ran.Next(1, DateTime.DaysInMonth(anyo, mes) + 1);
            DateTime fecha_inicio = new DateTime(anyo, mes, dia);
            DateTime fecha_fin = fecha_inicio;

            do {

                mostrar_menu1(salud, economia, religion, carisma, felicidad,valentia, fecha_inicio);

                try {

                    do {

                        mostrar_menu2(menu1);

                    } while (menu1 < 0 || menu1 > 5) ;

                    if (menu1 == 0) {

                        break;

                    }

                } catch (FormatException ex){

                    Console.WriteLine(ex.Message);

                } catch (Exception ex){

                    Console.WriteLine(ex.Message);

                }

                do {
      

                    try {

                        mostrar_menu3(menu2);

                    } catch (FormatException ex) {

                        Console.WriteLine(ex.Message);

                    }

                    catch (Exception ex) {

                        Console.WriteLine(ex.Message);

                    }

                    switch (menu2) {

                        case 1:

                            try {

                                Console.WriteLine("\nElija una cantidad: \n");
                                cantidad = int.Parse(Console.ReadLine());

                            } catch (FormatException ex) {

                                Console.WriteLine(ex.Message);

                            } catch (Exception ex) {

                                Console.WriteLine(ex.Message);

                            }

                            switch (menu1) {

                                case 1:

                                    salud += cantidad;
                                    Console.WriteLine("\n\tSalud total = {0}", salud);
                                    action = true;
                                    break;

                                case 2:

                                    economia += cantidad;
                                    Console.WriteLine("\n\tEconomía total = {0}", economia);
                                    action = true;
                                    break;

                                case 3:

                                    religion += cantidad;
                                    Console.WriteLine("\n\tReligion total = {0}", religion);
                                    action = true;
                                    break;

                                case 4:

                                    carisma += cantidad;
                                    Console.WriteLine("\n\tCarisma total = {0}", carisma);
                                    action = true;
                                    break;

                                case 5:

                                    felicidad += cantidad;
                                    Console.WriteLine("\n\tFelicidad total = {0}", felicidad);
                                    action = true;
                                    break;

                                default:

                                    Console.WriteLine("\n\tOpción inválida");
                                    break;            

                            }

                            if (action) {

                                action = false;
                                fecha_fin = cambiar_fecha(fecha_fin);

                            }

                            break;

                        case 2:

                            try {

                                Console.WriteLine("\n\tElija una cantidad: ");
                                cantidad = int.Parse(Console.ReadLine());

                            } catch (FormatException ex){

                                Console.WriteLine(ex.Message);

                            } catch (Exception ex){

                                Console.WriteLine(ex.Message);

                            }

                            switch (menu1) {

                                case 1:

                                    salud -= cantidad;
                                    action = true;

                                    if (salud > 0) {
                            
                                        Console.WriteLine("\n\tSalud total = {0}", salud);

                                    } else {

                                        menu1 = 0;
                                        menu2 = 0;
                                        
                                    }

                                    break;

                                case 2:

                                    economia -= cantidad;
                                    action = true;

                                    if (economia > 0) {

                                        Console.WriteLine("\n\tEconomía total = {0}", economia);

                                    } else {

                                        menu1 = 0;
                                        menu2 = 0;
                              
                                    }

                                    break;

                                case 3:

                                    religion -= cantidad;
                                    action = true;

                                    if (religion > 0) {

                                        Console.WriteLine("\n\tReligión total = {0}", religion);

                                    } else {

                                        menu1 = 0;
                                        menu2 = 0;

                                    }

                                    break;

                                case 4:

                                    carisma -= cantidad;
                                    action = true;

                                    if (carisma > 0) {
        
                                        Console.WriteLine("\n\tCarisma total = {0}", carisma);

                                    } else {

                                        menu1 = 0;
                                        menu2 = 0;
                                        
                                    }

                                    break;

                                case 5:

                                    felicidad -= cantidad;
                                    action = true;

                                    if (felicidad > 0){

                                        Console.WriteLine("\n\tFelicidad total = {0}", felicidad);

                                    } else {

                                        menu1 = 0;
                                        menu2 = 0;

                                    }

                                    break;

                            }

                            if (action) {

                                action = false;
                                fecha_fin=cambiar_fecha(fecha_fin);

                            }

                            break;

                    }

                } while (menu2 > 0);

            } while (menu1 > 0);

            Console.WriteLine("\n\t¡¡Que tenga un buen día!!");
            Console.WriteLine("\n\tFecha de fin de reinado {0}.\nHa reinado {1} años", DateOnly.FromDateTime(fecha_fin),Math.Floor(((fecha_fin-fecha_inicio).TotalDays)/365));
        }

        //CAMBIAR FECHA
        public static DateTime cambiar_fecha(DateTime fecha ){

            Random gen = new Random();

            int rango = gen.Next(1, 51);

            return fecha.AddYears(rango);
        }

        //MOSTRAR MENU 1
        public static void mostrar_menu1(int vida, int economia, int religion, int carisma, int felicidad,int valentia, DateTime fecha_inicio) {

            Console.WriteLine("\n\n\n=============================");
            Console.WriteLine("|         VALORES           |");
            Console.WriteLine("=============================");
            Console.WriteLine("\n\tSalud ------------ {0}" +
                "\n\tEconomia -------- {1}" +
                "\n\tReligion -------- {2}" +
                "\n\tCarisma --------- {3}" +
                "\n\tFelicidad ------- {4}" +
                "\n\tValentia ------- {5}" +
                "\n\tFecha Reinado --- {6}", vida, economia, religion, carisma, felicidad, valentia, DateOnly.FromDateTime(fecha_inicio));

        }

        //MOSTRAR MENU 2
        public static void mostrar_menu2(int menu1) {

            Console.WriteLine("\n=============================");
            Console.WriteLine("|         MENU              |");
            Console.WriteLine("=============================\n");
            Console.WriteLine("\t0. Salir");
            Console.WriteLine("\t1. Salud");
            Console.WriteLine("\t2. Economia");
            Console.WriteLine("\t3. Religion");
            Console.WriteLine("\t4. Carisma");
            Console.WriteLine("\t5. Felicidad");
            Console.WriteLine("\t6. Valentia");

            Console.WriteLine("\n\tElija una opción: ");
            menu1 = int.Parse(Console.ReadLine());

        }

        //MOSTRAR MENU 3
        public static void mostrar_menu3(int menu2) {

            Console.WriteLine("\n==============================");
            Console.WriteLine("|          OPERACION         |");
            Console.WriteLine("==============================\n");
            Console.WriteLine("\t0. Salir");
            Console.WriteLine("\t1. Aumentar");
            Console.WriteLine("\t2. Reducir\n");
            Console.WriteLine("\tElija una opción: ");
            menu2 = int.Parse(Console.ReadLine());

        }

    }

}


