using System.ComponentModel.DataAnnotations;

namespace BreakingLeague.Model
{
    public class Person
    {
        public int Person_Id
        {

            get;
            set;

        }


        public string Name
        {

            get;
            set;

        }


        public string Nationality
        {

            get;
            set;

        }


        public string City
        {

            get;
            set;

        }


        public int Age
        {

            get;
            set;

        }


        public Person() { }

        public Person(string name)
        {

            this.Name = name;


        }
        public Person(string name, int age)
        {

            this.Name = name;
            this.Age = age;

        }
        public Person(string name, string nationality, int age, string city)
        {

            this.Name = name;
            this.Nationality = nationality;
            this.Age = age;
            this.City = city;

        }

        public string ToString()
        {

            return "\n===============================\n" +
                "Nombre - " + this.Name + "\nNacionalidad - " + this.Nationality + "\nCiudad - " + this.City + "\nEdad - " + this.Age 
                ;

        }

    }
}
