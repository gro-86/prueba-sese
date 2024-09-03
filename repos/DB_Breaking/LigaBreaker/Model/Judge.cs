

using System.ComponentModel.DataAnnotations;

namespace BreakingLeague.Model
{

    public class Judge : Person
    {


        public Judge()
        {
        }

        public Judge(string nombre, Style criteria_1, Attitude criteria_2) : base(nombre)
        {

            this.Criteria1 = criteria_1;
            this.Criteria2 = criteria_2;

        }
        [Key]
        public int Judge_Id
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


        public Style Criteria1
        {

            get;
            set;

        }


        public Attitude Criteria2
        {

            get;
            set;

        }


        public string ToString()
        {

            return "\n===============================\n" +
                "Nombre - " + this.Name + "\nEdad - " + this.Age;

        }


    }
}
