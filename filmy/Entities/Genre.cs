using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmy.Entities
{
    public class Genre
    {
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

        public ICollection<Movie> Movies
        {
            get;
            set;
        }

#if DEBUG
        public static Genre Create(int id, string name)
        {
            var genre = new Genre()
            {
                Id = id,
                Name = name
            };

            return genre;
        }
#else
    public static Genre Create(string name)
    {
        var genre = new Genre()
        {
            Name = name
        };

        return genre;
    }
#endif
    }
}
