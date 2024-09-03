using BreakingLeague.Model;
using Microsoft.EntityFrameworkCore;

namespace BreakingLeague.Services
{
    public class ApplicationDbContext: DbContext{

        public DbSet<Crew> Crews { get; set; }
        public DbSet<Bboy> Signed_Bboys { get; set; }
        public DbSet<Judge> Judges { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Tournament> Tournaments{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=ESPC181415\SQLEXPRESS;Database=DB_Breaking;User Id=sa;Password=Sese@2024;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configuración de Crew y Bboy
            modelBuilder.Entity<Crew>()
                .HasMany(c => c.Bboys)
                .WithOne(b => b.Crew)
                .HasForeignKey(b => b.Crew_Id)
                .HasPrincipalKey(c => c.Crew_Id)  // Aquí deberías usar la clave primaria de Crew
                .OnDelete(DeleteBehavior.NoAction);  // Evitar cascada

            // Configuración de Tournament y Signed_Bboys
            modelBuilder.Entity<Tournament>()
                .HasMany(t => t.Signed_Bboys)
                .WithOne(b => b.Tournament)
                .HasForeignKey(b => b.Tournament_Id)
                .HasPrincipalKey(t => t.TournamentId)  // Aquí deberías usar la clave primaria de Tournament
                .OnDelete(DeleteBehavior.Restrict);  // Evitar cascada

            // Configuración de Tournament y Judges
            modelBuilder.Entity<Tournament>()
                .HasMany(t => t.Judges)
                .WithOne(b => b.Tournament)
                .HasForeignKey(b => b.Tournament_Id)
                .HasPrincipalKey(t => t.TournamentId)  // Aquí deberías usar la clave primaria de Tournament
                .OnDelete(DeleteBehavior.NoAction);  // Alternativamente, puedes usar Restrict

            /**
            // Configuración de Tournament y Crews
            modelBuilder.Entity<Tournament>()
                .HasMany(t => t.Crews)
                .WithOne(c => c.Tournament)
                .HasForeignKey(c => c.Tournament_Id)
                .HasPrincipalKey(t => t.Tournament_Id)  // Aquí deberías usar la clave primaria de Tournament
                .OnDelete(DeleteBehavior.NoAction);  // Evitar cascada*/

            // Configuración de Bboy y Skill (uno a uno)
            modelBuilder.Entity<Bboy>()
                .HasOne(b => b.Skill_)
                .WithOne(s => s.Bboy)
                .HasForeignKey<Skill>(s => s.Bboy_Id)
                .HasPrincipalKey<Bboy>(b => b.Bboy_Id);  // Usar la clave primaria de Bboy


            modelBuilder.Entity<Skill>()
                .HasKey(b => b.Skill_Id);

        }

    }
}
