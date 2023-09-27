using filmy.Entities;
using Microsoft.EntityFrameworkCore;

namespace filmy
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtistMovie>()
                .HasKey(am => new { am.MovieId, am.ArtistId });

            modelBuilder.Entity<ArtistMovie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.ArtistMovies)
                .HasForeignKey(am => am.MovieId);

            modelBuilder.Entity<ArtistMovie>()
                .HasOne(am => am.Artist)
                .WithMany(a => a.ArtistMovies)
                .HasForeignKey(am => am.ArtistId);

            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(m => m.GenreId);

            Seed.Initialize(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        #region nDbSet
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ArtistMovie> ArtistMovies { get; set; } 
        #endregion
    }
}
