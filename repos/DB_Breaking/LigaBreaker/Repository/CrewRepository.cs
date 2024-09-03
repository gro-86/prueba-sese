using BreakingLeague.Model;
using BreakingLeague.Services;
using BreakingLeague.Controller;

namespace BreakingLeague.Repository
{
    public class CrewRepository : IFunciones<Crew>
    {

        private readonly ApplicationDbContext Context;

        public CrewRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public void create(Crew crew)
        {
            Context.Add(crew);
            Context.SaveChanges();
        }

        public void delete(Crew crew)
        {
            Context.Remove(crew);
            Context.SaveChanges();
        }

        public Crew searchById(int id)
        {
            return Context.Crews.Find(id);
        }

        public IEnumerable<Crew> selectAll()
        {
            return Context.Crews.ToList();
        }

        public void update(Crew crew)
        {

            var cr = Context.Crews.Find(crew.Crew_Id);
            if (cr != null)
            {
                cr.Foundation = crew.Foundation;
                cr.Crew_Name = crew.Crew_Name;
                Context.SaveChanges();
            }

        }

    }
}
