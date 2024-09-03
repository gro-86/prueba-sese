using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioBiblioteca
{
    internal class Revista: Material
    {

        private int num_edicion;


        public Revista(string titulo, string autor, int anio_publicacion, string editorial, int num_edicion) : base(titulo, autor, anio_publicacion, editorial)
        {
            this.num_edicion = num_edicion;
        }

        public int Num_Edicion
        {

            get { return num_edicion; }
            set { num_edicion = value; }

        }

        public override string mostrar_tipo_material()
        {

            return "El material de la revista es bueno";
        }
        public override string mostrar_estado_material()
        {


            return "El material está nuevo";
        }

        public override string ToString()
        {


            return "\n------------------------------------" +
                base.ToString() + "\nNúmero de edición: " + num_edicion +
                "\n------------------------------------";

        }

    }
}
