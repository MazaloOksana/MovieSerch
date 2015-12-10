using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieSearch.Repository.Domain
{
    public class Department
    {
        public Department()
        {
            this.MovieToPerson = new HashSet<MovieToPerson>();
        }

        [Key]
        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MovieToPerson> MovieToPerson { get; set; }
    }
}