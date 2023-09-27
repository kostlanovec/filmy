using filmy.Entities;
using Microsoft.EntityFrameworkCore;

namespace filmy
{
    public class Seed
    {
        /// <summary>
        /// Inicializuje databázi se vzorovými daty, pokud nebyla již naplněna.
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder používaný pro konfiguraci datového modelu.</param>
        public static void Initialize(ModelBuilder modelBuilder)
        {

#if DEBUG
            var artist1 = Artist.Create(1, "Robert", "Downey Jr.", "American");
            var artist2 = Artist.Create(2, "Chris", "Evans", "American");
            modelBuilder.Entity<Artist>().HasData(artist1, artist2);

            var genre1 = Genre.Create(1, "Action");
            modelBuilder.Entity<Genre>().HasData(genre1);

            var movie1 = Movie.Create(1, "Iron Man", genre1);
            modelBuilder.Entity<Movie>().HasData(movie1);

            var artistMovie1 = ArtistMovie.Create(artist1, movie1);
            modelBuilder.Entity<ArtistMovie>().HasData(artistMovie1);
#endif
        }
    }
}
