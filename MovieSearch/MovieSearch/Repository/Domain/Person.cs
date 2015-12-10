using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieSearch.Repository.Domain
{
    public class Person
    {
        public Person()
        {
            this.MovieToPerson = new HashSet<MovieToPerson>();
        }

        [Key]
        public Guid Id { get; set; }
        public long KinopoiskId { get; set; }
        public string EnglishName { get; set; }
        public string RussianName { get; set; }

        public virtual ICollection<MovieToPerson> MovieToPerson { get; set; }
    }
}