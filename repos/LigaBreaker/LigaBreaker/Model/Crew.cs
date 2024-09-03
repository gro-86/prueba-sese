using System.ComponentModel.DataAnnotations.Schema;

namespace BreakingLeague.Model
{

    [Table("Crew")]
    public class Crew
    {

        private int crew_id;
        private string crew_name;
        private List<Bboy> bboys;
        private DateTime fundacion;

        public int Crew_Id
        {

            get { return crew_id; }
            set { crew_id = value; }

        }

        public string Crew_Name
        {

            get { return crew_name; }
            set { crew_name = value; }

        }

        public DateTime Fundacion
        {

            get { return fundacion; }
            set { fundacion = value; }

        }

        public List<Bboy> Bboys
        {

            get { return bboys; }
            set { bboys = value; }

        }

        public Crew()
        {



        }

        public Crew(string crew_name, List<Bboy> bboys, DateTime fundacion)
        {

            this.crew_name = crew_name;
            this.bboys = bboys;
            this.fundacion = fundacion;

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
                Console.WriteLine("El bboy: " + bboy.Aka + "ya no pertenece a: " + crew_name);

            }
            else
            {

                Console.WriteLine("El bboy especificado no pertenece a esta crew. ");

            }


        }

        public string ToString()
        {

            return "--------------------------------------" +
                "\nNombre " + crew_name + "\nFundación " + DateOnly.FromDateTime(fundacion) +
                "\n--------------------------------------";
        }

        public void ToString2()
        {
            foreach (Bboy bboy in bboys)
            {

                Console.WriteLine("\n" + bboy.ToString());

            }

        }

    }
}
