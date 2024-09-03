
namespace Torneo.Entidad
{
    internal class Elemento
    {
        private int id_elemento;
        private double power;
        private double footwork;
        private double freeze;
        private double style;

        public int Id_Elemento { get { return id_elemento; } set { id_elemento = value; } }
        public double Power { get { return power; } set { power = value; } }
        public double Footwork { get { return footwork; } set { footwork = value; } }
        public double Freeze { get { return freeze; } set { freeze = value; } }
        public double Style { get { return style; } set { style = value; } }

        public Elemento() { 
        
        
        }

        public Elemento(double power, double footwork, double freeze, double style)
        {
            this.power = power;
            this.footwork = footwork;
            this.freeze = freeze;
            this.style = style;

        }

        public void ToString() {


            Console.WriteLine("\nPower - "+power+"\nFootwork - "+footwork+"\nFreeze - "+freeze+"\nEstyle - "+style);
        
        }


    }
}
