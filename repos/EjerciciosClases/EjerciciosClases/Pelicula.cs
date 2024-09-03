using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClases
{
    internal class Pelicula
    {

        private int id;
        private string titulo;
        private string director;
        private double duracion;
        private DateTime estreno;
        private int [] calificaciones;

        public Pelicula()
        {

        }
        public Pelicula(string titulo, string director, double duracion, DateTime estreno) {

            this.titulo = titulo;
            this.director = director;
            this.duracion = duracion;
            this.estreno = estreno;
            this.calificaciones = new int[10];
        }

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Director { get { return director; } set { director = value; } }
        public double Duracion { get { return duracion; } set { duracion = value; } }
        public DateTime Estreno { get { return estreno; } set { estreno = value; } }
        public int [] Calificaciones { get { return calificaciones; } set { calificaciones = value; } }

        public void edad_actual() { 
            
            int fech= ((DateTime.Now).Year - this.estreno.Year);
            Console.WriteLine("Antigüedad de la peli: {0}",fech);

        }

        public void promedio() {

            Console.WriteLine("\nPromedio de calificaciones :{0}",calificaciones.Average());
        
        }

        public void rellenar_calificaciones()
        {
            Random ran = new Random();

            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {

                numeros[i] = ran.Next(1, 6);

            }

            this.calificaciones=numeros;

        }

        public string ToString() {

            return "\n\nTítulo: "+titulo+"\nDirector: "+director+"\nDuración: "+duracion+"\nEstreno: "+DateOnly.FromDateTime(estreno)+"\n";
        }

        public void ToString2()
        {

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("|\tCALIFICACIONES\t\t|");
            Console.WriteLine("---------------------------------\n");

            for (int x = 0; x < calificaciones.Length; x++) {

                Console.WriteLine("Calificación: {0}º - {1}",x+1,calificaciones[x]);
            
            }
            
        }
    }
}
