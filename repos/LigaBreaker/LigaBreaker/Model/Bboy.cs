using System.ComponentModel.DataAnnotations.Schema;

namespace BreakingLeague.Model
{

    [Table("Bboy")]
    public class Bboy : Person
    {

        private string aka;
        private Style style;
        private Attitude attitude;
        private bool injured;
        private int trophies;
        private Skill skill;

        public Bboy()
        {
        }

        public Bboy(string nombre, string nacionalidad, string ciudad, int edad, string aka, Style style, Attitude attitude, bool injured, int trophies, Skill skill) : base(nombre, nacionalidad, edad, ciudad)
        {

            this.aka = aka;
            this.style = style;
            this.attitude = attitude;
            this.injured = injured;
            this.trophies = trophies;
            this.skill = skill;

        }

        public string Aka
        {

            get { return aka; }
            set { aka = value; }

        }

        public Style Style_
        {

            get { return style; }
            set { style = value; }

        }

        public bool Injured
        {

            get { return injured; }
            set { injured = value; }

        }

        public int Trophies
        {

            get { return trophies; }
            set { trophies = value; }

        }

        public Skill Skill_
        {

            get { return skill; }
            set { skill = value; }

        }

        public Attitude Attitude
        {

            get { return attitude; }
            set { attitude = value; }

        }

        public void I_inscribir_torneo()
        {



        }

        public string ToString()
        {

            return "\n===============================\n" +
                "Nombre - " + this.Name + "\nNacionalidad - " + this.Nationality + "\nCiudad - " + this.City + "\nEdad - " + this.Age + "\nEstilo - " + style + "\nAKA - " + aka + "\nEstilo - " + style + "\nLesionado - " + injured +
                "\nActitud - " + attitude + "\nTorneos ganados - " + trophies;

        }

    }
}
