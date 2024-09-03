using BreakingLeague.Model;
using BreakingLeague.Services;

namespace BreakingLeague.Repository
{
    internal class SkillRepository
    {

        private readonly ApplicationDbContext Context;

        public SkillRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public void create(Skill skill)
        {
            Context.Add(skill);
            Context.SaveChanges();

        }

        public void delete(Skill skill)
        {
            Context.Remove(skill);
            Context.SaveChanges();
        }

        public Skill searchById(int id)
        {
            return Context.Skills.Find(id);
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
}
