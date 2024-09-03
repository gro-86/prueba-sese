using BreakingLeague.Controller;
using BreakingLeague.Model;
using BreakingLeague.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingLeague.Repository
{
    public class TournamentRepository : IFunciones<Tournament>
    {
        private readonly ApplicationDbContext Context;

        public TournamentRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public void create(Tournament tournament)
        {
            Context.Add(tournament);
            Context.SaveChanges();
        }

        public void delete(Tournament tournament)
        {
            Context.Remove(tournament);
            Context.SaveChanges();
        }

        public Tournament searchById(int id)
        {
            return Context.Tournaments.Find(id);
        }

        public IEnumerable<Tournament> selectAll()
        {
            return Context.Tournaments.ToList();
        }

        public void update(Tournament tournament)
        {

            var to = Context.Tournaments.Find(tournament.TournamentId);
            if (to != null)
            {
                to.Duration = tournament.Duration;
                to.Tournament_Name = tournament.Tournament_Name;

                Context.SaveChanges();
            }

        }

    }
}
