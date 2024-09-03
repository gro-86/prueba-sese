using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreakingLeague.Model
{

    public class Crew
    {
        [Key]
        public int Crew_Id
        {

            get;
            set;

        }


        public string Crew_Name
        {

            get;
            set;

        }


        public Tournament Tournament
        {

            get;
            set;

        }

        [ForeignKey("TournamentId")]
        public int TournamentId
        {

            get;
            set;

        }


        public DateTime Foundation
        {

            get;
            set;

        }


        public ICollection<Bboy> Bboys
        {

            get;
            set;

        }


        public Crew()
        {



        }

        public Crew(string crew_name, DateTime foundation)
        {

            this.Crew_Name = crew_name;
            this.Foundation = foundation;

        }

        public Crew(string crew_name, List<Bboy> bboys, DateTime foundation)
        {

            this.Crew_Name = crew_name;
            this.Bboys = bboys;
            this.Foundation = foundation;

        }

        public void aceptar_bboy(Bboy bboy)
        {
            double total = (bboy.Skill_.Freeze + bboy.Skill_.Power + bboy.Skill_.Style + bboy.Skill_.Footwork);
            if (Bboys.Count < 10 && total > 30)
            {
                if (bboy.Attitude == Attitude.CHILL)
                {
                    Console.WriteLine("¡¡¡Aquí no queremos a vagos!!!");
                }
                else
                {

                    Bboys.Add(bboy);

                }
            }

        }

        public void echar_bboy(Bboy bboy)
        {

            if (Bboys.Contains(bboy))
            {

                Bboys.Remove(bboy);
                Console.WriteLine("El bboy: " + bboy.Aka + "ya no pertenece a: " + Crew_Name);

            }
            else
            {

                Console.WriteLine("El bboy especificado no pertenece a esta crew. ");

            }


        }

        public string ToString()
        {

            return "--------------------------------------" +
                "\nNombre " + Crew_Name + "\nFundación " + DateOnly.FromDateTime(Foundation) +
                "\n--------------------------------------";
        }

        public void ToString2()
        {
            foreach (Bboy bboy in Bboys)
            {

                Console.WriteLine("\n" + bboy.ToString());

            }

        }

    }
}
