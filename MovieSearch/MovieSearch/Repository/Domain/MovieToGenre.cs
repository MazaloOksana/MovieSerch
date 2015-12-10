using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSearch.Repository.Domain
{
    public class MovieToGenre
    {
        [Key, Column(Order = 0)]
        public Guid MovieId { get; set; }
        [Key, Column(Order = 1)]
        public int GenreId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Genre Genre { get; set; }
    }
}