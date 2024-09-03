using Torneo.Entidad;
using Torneo.Entity;
using Torneos.Entidad;

namespace Entidad 
{
    internal class Bboy : Persona
    {

        private string aka;
        private Estilo estilo;
        private Actitud actitud;
        private bool lesionado;
        private int torneos_ganados;
        private int ranking_mundial;

        public Bboy() { 
        }

        public Bboy(string nombre,string nacionalidad,string ciudad,int edad, string aka, Estilo estilo,Actitud actitud, bool lesionado, int torneos_ganados, int ranking_mundial): base(nombre, nacionalidad,edad, ciudad){
        
            this.aka = aka;
            this.estilo = estilo;
            this.actitud = actitud;
            this.lesionado = lesionado;
            this.torneos_ganados = torneos_ganados;
            this.ranking_mundial = ranking_mundial;

        }

        public string Aka { 
        
            get { return aka; }
            set { aka = value; }
        
        }

        public string Estilo
        {

            get { return Estilo; }
            set { Estilo = value; }

        }

        public bool Lesionado
        {

            get { return lesionado; }
            set { lesionado = value; }

        }

        public int Torneos_Ganados
        {

            get { return torneos_ganados; }
            set { torneos_ganados = value; }

        }

        public int Ranking_Mundial
        {

            get { return ranking_mundial; }
            set { ranking_mundial = value; }

        }

        public string ToString() {


            return "\n===============================\n"+
                "Nombre - "+this.Nombre+"\nNacionalidad - "+this.Nacionalidad+"\nCiudad - "+this.Ciudad+"\nEdad - "+this.Edad+"\nEstilo - "+estilo+"\nAKA - "+aka+"\nEstilo - "+estilo+"\nLesionado - "+lesionado+
                "\nActitud - "+actitud+"\nTorneos ganados - "+torneos_ganados+"\nRanking mundial - "+ranking_mundial;
        
        }


    }
}
