
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BreakingLeague.Model
{

    [Table("Tournament")]
    public class Tournament
    {
        [MaxLength(20)]
        private string championship_name;
        [MaxLength(3)]
        private int duration;
        private List<Bboy> signed_bboys;
        private List<Judge> judges;

        public string Championship_Name
        {

            get { return championship_name; }
            set { championship_name = value; }

        }

        public int Duration
        {

            get { return duration; }
            set { duration = value; }

        }

        public List<Bboy> Signed_Bboys
        {

            get { return signed_bboys; }
            set { signed_bboys = value; }

        }

        public List<Judge> Jueces
        {

            get { return judges; }
            set { judges = value; }

        }

        public Tournament() { }

        public Tournament(string nombre_campeonato, int duracion, List<Bboy> bboys_inscritos)
        {

            this.championship_name = nombre_campeonato;
            this.duration = duracion;
            this.signed_bboys = bboys_inscritos;

        }

        //INICIAR CAMPEONATO
        public void iniciar_campeonato()
        {

            List<Bboy> diecisesavos = desordenar(signed_bboys);
            List<Bboy> octavos = new List<Bboy>();
            List<Bboy> cuartos = new List<Bboy>();
            List<Bboy> seminifinal = new List<Bboy>();
            List<Bboy> batalla_final = new List<Bboy>();
            Random random = new Random();

            for (int x = 0; x < diecisesavos.Count; x++)
            {

                if (x != diecisesavos.Count - 1)
                {

                }

            }

        }

        public void descalificar_crew()
        {



        }

        public List<Bboy> desordenar(List<Bboy> bboys_inscritos)
        {

            Random random = new Random();

            List<Bboy> lista_desordenada = new List<Bboy>();

            for (int x = lista_desordenada.Count - 1; x > 0; x--)
            {
                int ale = random.Next(0, x + 1);
                var temp = lista_desordenada[x];
                lista_desordenada[x] = lista_desordenada[ale];
                lista_desordenada[ale] = temp;
            }

            return lista_desordenada;

        }

        public void ToString()
        {
            Console.WriteLine("\nNombre torneo " + championship_name + "\nDuración " + duration);

        }

        public void ToString2()
        {
            foreach (Bboy bboy in signed_bboys)
            {

                Console.WriteLine("\n" + bboy.ToString());
                bboy.ToString();

            }

        }

    }
}
