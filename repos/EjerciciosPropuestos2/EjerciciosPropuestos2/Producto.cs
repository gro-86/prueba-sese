using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPropuestos2_Auro_Ben
{
    internal class Producto
    {

        private int id_producto;
        private string nombre_producto;
        private double precio;

        public int Id_Producto
        {

            get { return id_producto; }
            set { id_producto = value; }

        }

        public string Nombre_Producto
        {

            get { return nombre_producto; }
            set { nombre_producto = value; }

        }

        public double Precio
        {

            get { return precio; }
            set { precio = value; }

        }

        public Producto()
        {


        }
        public Producto(int id_producto, string nombre_producto, double precio)
        {

            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.precio = precio;


        }

        public string ToString()
        {

            return "Nombre producto: " + nombre_producto+ "\nPrecio: "+precio;
        }
    }
}
