using System.ComponentModel.DataAnnotations;

namespace filmy.Entities
{
    public class Artist
    {
        [Key]
        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Nationality
        {
            get;
            set;
        }

        public ICollection<ArtistMovie> ArtistMovies
        {
            get;
            set;
        }

#if DEBUG
        public static Artist Create(int id, string firstName, string lastName, string nationality)
        {
            var artist = new Artist()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Nationality = nationality
            };
            return artist;
        }
#else
    public static Artist Create(string firstName, string lastName, string nationality)
    {
        var artist = new Artist()
        {
            FirstName = firstName,
            LastName = lastName,
            Nationality = nationality
        };
        return artist;
    }
#endif
    }
}
