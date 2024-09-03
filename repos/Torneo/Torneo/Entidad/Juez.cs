
using Torneo.Entidad;

namespace Torneos.Entidad
{
    internal class Juez : Persona
    {

        private Estilo criterio_1;
        private Elemento criterio_2;

        public Juez()
        {
        }

        public Juez(string nombre, int edad, Estilo criterio_1, Elemento criterio_2) : base(nombre, edad)
        {

            this.criterio_1 = criterio_1;
            this.criterio_2 = criterio_2;

        }

        public string Estilo
        {

            get { return Estilo; }
            set { Estilo = value; }

        }

        public string ToString()
        {


            return "\n===============================\n" +
                "Nombre - " + this.Nombre + "\nNacionalidad - " + this.Nacionalidad + "\nCiudad - " + this.Ciudad + "\nEdad - " + this.Edad + "\nEstilo - " + estilo + "\nAKA - " + aka + "\nEstilo - " + estilo + "\nLesionado - " + lesionado +
                "\nActitud - " + actitud + "\nTorneos ganados - " + torneos_ganados + "\nRanking mundial - " + ranking_mundial;

        }


    }
}
