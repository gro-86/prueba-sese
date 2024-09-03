using BreakingLeague.Controller;
using BreakingLeague.Model;
using BreakingLeague.Services;

namespace BreakingLeague.Repository
{
    public class JudgeRepository : IFunciones<Judge>
    {

        private readonly ApplicationDbContext Context;

        public JudgeRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public void create(Judge judge)
        {
            Context.Add(judge);
            Context.SaveChanges();
        }

        public void delete(Judge judge)
        {
            Context.Remove(judge);
            Context.SaveChanges();
        }

        public Judge searchById(int id)
        {
            return Context.Judges.Find(id);
        }

        public IEnumerable<Judge> selectAll()
        {
            return Context.Judges.ToList();
        }

        public void update(Judge judge)
        {

            var ju = Context.Judges.Find(judge.Judge_Id);
            if (ju != null)
            {
                ju.Name = judge.Name;
                ju.Criteria1 = judge.Criteria1;
                ju.Criteria2 = judge.Criteria2;
                Context.SaveChanges();
            }

        }

    }
}
