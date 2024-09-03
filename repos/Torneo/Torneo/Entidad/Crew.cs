using Entidad;

namespace Torneo.Entidad
{
    internal class Crew
    {
        private int crew_id;
        private string crew_name;
        private List<Bboy> bboys;
        private DateTime fundacion;

        public int Crew_Id { 
        
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

        public Crew(string crew_name, List<Bboy>bboys, DateTime fundacion) { 
             
            this.crew_name = crew_name;
            this.bboys = bboys;
            this.fundacion = fundacion;
        
        }

        public string ToString() {

            return "--------------------------------------"+
                "\nNombre "+crew_name+"\nFundación "+DateOnly.FromDateTime(fundacion)+ 
                "\n--------------------------------------";
        }

        public void ToString2()
        {
            foreach (Bboy bboy in bboys) {
            
                Console.WriteLine("\n"+bboy.ToString());
            
            }

        }

    }
}
