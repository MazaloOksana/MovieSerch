using System;
using System.ComponentModel.DataAnnotations;

namespace MovieSearch.Repository.Domain
{
    public class MovieToPerson
    {
        [Key]
        public Guid MovieId { get; set; }
        public Guid PersonId { get; set; }
        public byte DepartmentId { get; set; }
        public string Role { get; set; }

        public virtual Department Department { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
    }
}