using Entidad;
using Torneo.Entidad;
using Torneos.Entidad;


namespace Torneos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bboy bboy1 = new Bboy("Moises", "USA","Houston", 38, "Moy", Torneo.Entidad.Estilo.FOOTWORKER, Actitud.PROVOCADOR, false, 57, 120);
            Bboy bboy2 = new Bboy("Daniel", "USA", "San Francisco", 40, "Cloud", Torneo.Entidad.Estilo.RYTHMIC, Actitud.PROVOCADOR, false, 60, 128);
            Bboy bboy3 = new Bboy("John", "USA", "Houston", 45, "Lil John", Torneo.Entidad.Estilo.FREESTYLER, Actitud.AGRESIVO, false, 34, 200);
            Bboy bboy4 = new Bboy("Rawdel", "USA", "San Francisco", 44, "FleaRock", Torneo.Entidad.Estilo.FLOW, Actitud.RELAJADO, false, 129, 45);
            Bboy bboy5 = new Bboy("Lawrence", "USA", "Chicago", 36, "Law", Estilo.TRANSFERER, Entidad.Actitud.RELAJADO, false, 30, 250);
            Bboy bboy6 = new Bboy("Obie", "USA", "Boston", 43, "Raw Skeleton", Torneo.Entidad.Estilo.FREEZER, Entidad.Actitud.AGRESIVO, false, 13, 265);

            List<Bboy> bboys1 = new List<Bboy>();
            List<Bboy> bboys2 = new List<Bboy>();
            List<Bboy> bboys3 = new List<Bboy>();       

            bboys1.Add(bboy1);
            bboys1.Add(bboy2);
            bboys2.Add(bboy3);
            bboys2.Add(bboy4);
            bboys3.Add(bboy5);
            bboys3.Add(bboy6);
            

            Crew crew1 = new Crew("Havikoro",bboys1,DateTime.Parse("1994-02-11"));
            Crew crew2 = new Crew("Skill Methodz", bboys2, DateTime.Parse("1990-11-11"));
            Crew crew3 = new Crew("Freakshow", bboys3, DateTime.Parse("2000-02-11"));

            List<Crew> inscritos1 = new List<Crew>();

            inscritos1.Add(crew1);
            inscritos1.Add(crew2);
            inscritos1.Add(crew3);
            Campeonato campeonato1 = new Campeonato("Primera edicion",120,inscritos1);

            campeonato1.ToString();
            campeonato1.ToString2();

        }
    }
}
