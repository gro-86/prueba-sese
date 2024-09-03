using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPropuestos2_Ser_Tom
{
    internal class Garaje
    {

        private int id_garaje;
        private string nombre_garaje;
        private HashSet<Vehiculo> vehiculos = new HashSet<Vehiculo>();

        public int Id_Garaje {

            get { return id_garaje; }
            set { id_garaje = value; }
        
        }

        public string Nombre_Garaje
        {

            get { return nombre_garaje; }
            set { nombre_garaje = value; }

        }

        public HashSet<Vehiculo> Vehiculos
        {

            get { return vehiculos; }
            set { vehiculos = value; }

        }

        public Garaje()
        {

        }

        public Garaje(string nombre_garaje, HashSet<Vehiculo>vehiculos)
        {
            this.vehiculos = vehiculos;
      
        }

        public void ToString() {

            Console.WriteLine("Nombre garaje: "+nombre_garaje);
            foreach (Vehiculo ve in vehiculos)
            {
                Console.WriteLine(ve.ToString());
            }
        }

    }
}
