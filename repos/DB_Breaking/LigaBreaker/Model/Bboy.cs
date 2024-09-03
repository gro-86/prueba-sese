using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreakingLeague.Model
{
    public class Bboy : Person
    {
        
        public Bboy()
        {
          

        }
        public Bboy(string name, string nationality, string city, int edad, string aka, Style style, Attitude attitude, bool injured, int trophies, Skill skill) : base(name, nationality, edad, city)
        {
            this.Aka = aka;
            this.Style_ = style;
            this.Attitude = attitude;
            this.Injured = injured;
            this.Trophies = trophies;
            this.Skill_ = skill;

        }
        [Key]
        public int Bboy_Id
        {

            get;
            set;

        }


        public Crew Crew
        {

            get;
            set;

        }


        public int Crew_Id
        {

            get;
            set;

        }

        public int Skill_Id
        {

            get;
            set;

        }

        public int Tournament_Id
        {

            get;
            set;

        }


        public Tournament Tournament
        {

            get;
            set;

        }

        public string Aka
        {

            get;
            set;

        }

        public Style Style_
        {

            get;
            set;

        }


        public bool Injured
        {

            get;
            set;

        }


        public int Trophies
        {

            get;
            set;

        }


        public Skill Skill_
        {

            get;
            set;

        }

        public Attitude Attitude
        {

            get;
            set;

        }


        public void I_inscribir_torneo()
        {



        }

        public string ToString()
        {

            return base.ToString() + this.Age + "\nEstilo - " + Style_ + "\nAKA - " + Aka + "\nLesionado - " + Injured +
                "\nActitud - " + Attitude + "\nTorneos ganados - " + Trophies;

        }

    }
}
