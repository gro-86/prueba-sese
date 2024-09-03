using BreakingLeague.Controller;
using BreakingLeague.Services;
using BreakingLeague.Model;

namespace BreakingLeague.Repository;

    public class BboyRepository : IFunciones<Bboy>
    {

        private readonly ApplicationDbContext Context;

        public BboyRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public void create(Bboy bboy)
        {
            Context.Add(bboy);
            Context.SaveChanges();

        }

        public void delete(Bboy bboy)
        {
            Context.Remove(bboy);
            Context.SaveChanges();
        }

        public Bboy searchById(int id)
        {
            return Context.Signed_Bboys.Find(id);
        }

        public IEnumerable<Bboy> selectAll()
        {
            return Context.Signed_Bboys.ToList();
        }

        public void update(Bboy bboy)
        {

            var bb = Context.Signed_Bboys.Find(bboy.Bboy_Id);
            if (bb != null)
            {
                bb.Aka = bboy.Aka;
                bb.Style_ = bboy.Style_;
                bb.Attitude = bboy.Attitude;
                bb.Trophies = bboy.Trophies;
                bb.Injured = bboy.Injured;
                bb.Nationality = bboy.Nationality;
                bb.Age = bboy.Age;
                bb.City = bboy.City;
                bb.Skill_ = bboy.Skill_;
                Context.SaveChanges();
            }

        }

    }
