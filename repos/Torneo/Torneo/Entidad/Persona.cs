
namespace Torneo.Entity
{
    internal class Persona
    {

        private int id_persona;
        private string nombre;
        private string nacionalidad;
        private string ciudad;
        private int edad;

        public int Id_Persona
        {

            get { return id_persona; }
            set { id_persona = value; }

        }

        public string Nombre
        {

            get { return nombre; }
            set { nombre = value; }

        }

        public string Nacionalidad
        {

            get { return nacionalidad; }
            set { nacionalidad = value; }

        }

        public string Ciudad
        {

            get { return ciudad; }
            set { ciudad = value; }

        }

        public int Edad
        {
            get { return edad; }
            set { edad= value; }
        }

        public Persona() { }

        public Persona(string nombre, int edad)
        {

            this.nombre = nombre;
            this.edad = edad;

        }
        public Persona(string nombre, string nacionalidad, int edad, string ciudad)
        {

            this.nombre = nombre;
            this.nacionalidad= nacionalidad;
            this.edad = edad;
            this.ciudad = ciudad;

        }


    }
}
