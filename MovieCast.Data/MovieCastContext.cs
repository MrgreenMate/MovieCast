using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieCast.Data.Helpers;
using MovieCast.Entities.Entity;

namespace MovieCast.Data
{
    public class MovieCastContext : IdentityDbContext<AppUser>
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CastPair> CastPairs { get; set; }

        public MovieCastContext(DbContextOptions<MovieCastContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Egy film - több szereplő-színész pár; egy pár csak egy filmhez tartozhat
            modelBuilder.Entity<CastPair>()
                .HasOne(c => c.Movie)
                .WithMany(m => m.CastPairs)
                .HasForeignKey(c => c.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
