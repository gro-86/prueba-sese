using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBiblioteca
{
    internal class DVD: Material
    {

        private int duracion;

        public DVD(string titulo, string autor, int anio_publicacion, string editorial, int duracion) : base(titulo, autor, anio_publicacion, editorial)
        {
            this.duracion = duracion;
        }

        public int Duracion
        {

            get { return duracion; }
            set { duracion = value; }

        }

        public override string mostrar_tipo_material()
        {

            return "El material del DVD es pésimo";
        }
        public override string mostrar_estado_material()
        {


            return "El material está reventado";
        }

        public override string ToString()
        {


            return "\n------------------------------------" +
                base.ToString() + "\nDuración: " + duracion +
                "\n------------------------------------";

        }

    }
}
