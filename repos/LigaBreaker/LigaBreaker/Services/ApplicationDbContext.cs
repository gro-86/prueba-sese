using BreakingLeague.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingLeague.Services
{
    public class ApplicationDbContext: DbContext{

        public ApplicationDbContext(DbContextOptions options): base(options){



        }

        public DbSet<Bboy> bboys { get; set; }
        public DbSet<Crew> crews { get; set; }
        public DbSet<Tournament> tournaments { get; set; }
    }
}
