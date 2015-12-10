using System;
using System.ComponentModel.DataAnnotations;

namespace MovieSearch.Repository.Domain
{
    public class Posters
    {
        [Key]
        public Guid MovieId { get; set; }
        public long PosterId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}