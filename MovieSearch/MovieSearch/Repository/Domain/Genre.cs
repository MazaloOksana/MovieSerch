using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieSearch.Repository.Domain
{
    public class Genre
    {
        public Genre()
        {
            this.MovieToGenres = new HashSet<MovieToGenre>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MovieToGenre> MovieToGenres { get; set; }
    }
}