
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Reflection.Metadata.BlobBuilder;


namespace BreakingLeague.Model
{
    public class Tournament
    {
        private int tournamentid;
        private string tournament_name;
        private int duration;
        private ICollection<Bboy> signed_bboys;
        private ICollection<Judge> judges;
        private ICollection<Crew> crews;

        [Key]
        public int TournamentId
        {

            get { return tournamentid; }
            set { tournamentid = value; }

        }

        public string Tournament_Name
        {

            get { return tournament_name; }
            set { tournament_name = value; }

        }

        public string Championship_Name
        {

            get { return tournament_name; }
            set { tournament_name = value; }

        }

        public int Duration
        {

            get { return duration; }
            set { duration = value; }

        }

        public ICollection<Bboy> Signed_Bboys
        {

            get { return signed_bboys; }
            set { signed_bboys = value; }

        }

        public ICollection<Judge> Judges
        {

            get { return judges; }
            set { judges = value; }

        }

        public ICollection<Crew> Crews
        {

            get { return crews; }
            set { crews = value; }

        }

        public Tournament(string tournament_name)
        {

            this.tournament_name = tournament_name;
           

        }

        public Tournament(int duration)
        {

            this.duration = duration;

        }

        public Tournament(string tournament_name, int duration)
        {

            this.tournament_name = tournament_name;
            this.duration = duration;

        }

        public Tournament(string tournament_name, int duration, ICollection<Bboy> signed_bboys, ICollection<Crew> crews)
        {

            this.tournament_name = tournament_name;
            this.duration = duration;
            this.signed_bboys = signed_bboys;
            this.crews = crews;

        }

        public Tournament(string tournament_name, int duration, ICollection<Bboy> signed_bboys)
        {

            this.tournament_name = tournament_name;
            this.duration = duration;
            this.signed_bboys = signed_bboys;

        }

        //INICIAR CAMPEONATO
        public void iniciar_campeonato()
        {

            ICollection<Bboy> diecisesavos = desordenar(signed_bboys);
            ICollection<Bboy> octavos = new List<Bboy>();
            ICollection<Bboy> cuartos = new List<Bboy>();
            ICollection<Bboy> seminifinal = new List<Bboy>();
            ICollection<Bboy> batalla_final = new List<Bboy>();
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

        public ICollection<Bboy> desordenar(ICollection<Bboy> signed_bboys)
        {

            Random ran = new Random();

            ICollection<Bboy> shuffled_list  = signed_bboys.OrderBy(b => ran.Next()).ToList();

            return shuffled_list;

        }

        public void ToString()
        {
            Console.WriteLine("\nNombre torneo " + tournament_name + "\nDuración " + duration);

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
