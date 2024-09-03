using System.ComponentModel.DataAnnotations;

namespace BreakingLeague.Model
{
    public class Person
    {

        [MaxLength(7)]
        private int person_id;
        [MaxLength(20)]
        private string name;
        [MaxLength(20)]
        private string nationality;
        [MaxLength(20)]
        private string city;
        [MaxLength(3)]
        private int age;

        public int Person_Id
        {

            get { return person_id; }
            set { person_id = value; }

        }

        public string Name
        {

            get { return name; }
            set { name = value; }

        }

        public string Nationality
        {

            get { return nationality; }
            set { nationality = value; }

        }

        public string City
        {

            get { return city; }
            set { city = value; }

        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person() { }

        public Person(string name)
        {

            this.name = name;


        }
        public Person(string name, int edad)
        {

            this.name = name;
            this.age = edad;

        }
        public Person(string name, string nacionalidad, int edad, string ciudad)
        {

            this.name = name;
            this.nationality = nacionalidad;
            this.age = edad;
            this.city = ciudad;

        }




    }
}
