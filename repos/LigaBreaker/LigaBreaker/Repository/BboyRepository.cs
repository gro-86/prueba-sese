using BreakingLeague.Controller;
using BreakingLeague.Model;

namespace BreakingLeague.Repository
{
    internal class BboyRepository : IFunciones<Bboy>
    {

        private ApplicationDbContext context;

        public BboyRepository()
        {
            context = new ApplicationDbContext();
        }

        public void create(Bboy bboy)
        {
            context.bboys.Add(bboy);
            context.SaveChanges();

        }

        public void delete(Bboy bboy)
        {
            context.bboys.Remove(bboy);
            context.SaveChanges();
        }

        public Bboy searchById(int id)
        {
            return context.bboys.Find(id);
        }

        public IEnumerable<Bboy> selectAll()
        {
            return context.bboys;
        }

        public void update(Bboy bboy)
        {

            var bb = context.bboys.Find(bboy.Person_Id);
            if (bb == null)
            {
                bb.Name = bboy.Name;
                bb.Aka = bboy.Aka;
                bb.Style_ = bboy.Style_;
                bb.Attitude = bboy.Attitude;
                bb.Trophies = bboy.Trophies;
                bb.Injured = bboy.Injured;
                bb.Nationality = bboy.Nationality;
                bb.Age = bboy.Age;
                bb.City = bboy.City;
                bb.Skill_ = bboy.Skill_;

            }


        }

    }

}
