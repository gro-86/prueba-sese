namespace BreakingLeague.Model;
using System.ComponentModel.DataAnnotations;


    public class Skill
    {


        public Bboy Bboy { get; set; }

        [Key]
        public int Skill_Id { get; set; }

        public int Bboy_Id { get; set; }
        public double Power { get; set; }
        public double Footwork { get; set; }
        public double Freeze { get; set; }
        public double Style { get; set; }

        public Skill()
        {


        }

        public Skill(double power, double footwork, double freeze, double style)
        {
            this.Power = power;
            this.Footwork = footwork;
            this.Freeze = freeze;
            this.Style = style;

        }

        public void ToString()
        {


            Console.WriteLine("\nPower - " + Power + "\nFootwork - " + Footwork + "\nFreeze - " + Freeze + "\nStyle - " + Style);

        }
    
    }
