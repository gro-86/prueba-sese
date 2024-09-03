using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreakingLeague.Model
{

    [Table("Judge")]
    public class Judge : Person
    {
        [MaxLength(20)]
        private Style criterio_1;
        [MaxLength(20)]
        private Attitude criterio_2;
        [MaxLength(20)]
        private string nombre;

        public Judge()
        {
        }

        public Judge(string nombre, Style criterio_1, Attitude criterio_2) : base(nombre)
        {
            this.nombre = nombre;
            this.criterio_1 = criterio_1;
            this.criterio_2 = criterio_2;

        }

        public string Estilo
        {

            get { return Estilo; }
            set { Estilo = value; }

        }

        public string ToString()
        {

            return "\n===============================\n" +
                "Nombre - " + this.Name + "\nEdad - " + this.Age;

        }


    }
}
