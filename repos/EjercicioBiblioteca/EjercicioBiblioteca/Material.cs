using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBiblioteca
{
    internal abstract class Material :IResis
    {
        private string titulo;
        private string autor;
        private int anio_publicacion;
        private string editorial;
        
        public string Titulo {

            get { return titulo; }
            set { titulo = value; }
        
        }

        public string Autor
        {

            get { return autor; }
            set { autor = value; }

        }

        public int Anio_Publicacion
        {

            get { return anio_publicacion; }
            set { anio_publicacion = value; }

        }

        public string Editorial
        {

            get { return editorial; }
            set { editorial = value; }

        }

        public Material(string titulo, string autor, int anio_publicacion, string editorial) { 
        
            this.titulo = titulo;
            this.autor = autor; 
            this.anio_publicacion= anio_publicacion;
            this.editorial = editorial;
        
        }

        public virtual string mostrar_tipo_material() {

            return "El material es de baja calidad";
        }
        public virtual string mostrar_estado_material() {


            return "El material está desgastado";
        }

        public virtual string ToString() {


            return "\n-------------------------------"+
                "\nTítulo: "+titulo+"\nAutor: "+autor+"\nAño publicacion: "+anio_publicacion+"\nEditorial: "+editorial;
        }

    }
}
