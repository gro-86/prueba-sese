using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPropuestos2_Auro_Ben
{
    internal class Proveedor
    {
        private int id_proveedor;
        private string nombre_proveedor;

        public int Id_Proveedor {

            get{ return id_proveedor; }
            set {id_proveedor = value; }

        }

        public string Nombre_Proveedor
        {

            get { return nombre_proveedor; }
            set { nombre_proveedor = value; }

        }

        public Proveedor()
        {

        }

        public Proveedor(int id_proveedor,string nombre_proveedor) { 
        
            this.id_proveedor = id_proveedor;
            this.nombre_proveedor=nombre_proveedor;

        }
        public string ToString() {

            return "Nombre proveedor: "+nombre_proveedor;
        }

    }
}
