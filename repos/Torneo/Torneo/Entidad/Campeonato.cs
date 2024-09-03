
using Entidad;
using Torneo.Entidad;

namespace Torneos.Entidad
{
    internal class Campeonato
    {

        private string nombre_campeonato;
        private int duracion;
        private List<Crew> crews_inscritas;

        public string Nombre_Campeonato { 
        
            get { return nombre_campeonato; }
            set { nombre_campeonato = value; }
        
        }

        public int Duracion
        {

            get { return duracion; }
            set { duracion = value; }

        }

        public List<Crew> Crews_Inscritas
        {

            get { return crews_inscritas; }
            set { crews_inscritas = value; }

        }

        public Campeonato() { }

        public Campeonato(string nombre_campeonato, int duracion, List<Crew>crews_inscritas) {
            
            this.nombre_campeonato=nombre_campeonato;
            this.duracion=duracion;
            this.crews_inscritas=crews_inscritas;
        
        }

        public void ToString()
        {
            Console.WriteLine("\nNombre torneo "+nombre_campeonato+"\nDuración "+duracion);

        }

        public void ToString2()
        {
            foreach (Crew crew in crews_inscritas)
            {

                Console.WriteLine("\n" + crew.ToString());
                crew.ToString2();

            }

        }

    }
}
