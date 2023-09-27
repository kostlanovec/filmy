using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmy.Entities
{
    public class Movie
    {
        protected Movie(){}


        [Key]
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get; 
            set;
        }

        public int GenreId
        {
            get;
            set;
        }  // Cizí klíč pro Genre

        public Genre Genre
        {
            get;
            set;
        }  // Navigační vlastnost pro Genre

        public ICollection<ArtistMovie> ArtistMovies
        {
            get; 
            set;
        }  // Vazba N:M s Artist

#if DEBUG
        public static Movie Create(int id, string name, Genre genre)
        {
            var movie = new Movie()
            {
                Id = id,
                Name = name,
                GenreId = genre.Id
            };

            return movie;
        }
#else
    public static Movie Create(string name, Genre genre)
    {
        var movie = new Movie()
        {
            Name = name,
            GenreId = genre.Id
        };

        return movie;
    }
#endif
    }
}
