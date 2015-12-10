using System.ComponentModel.DataAnnotations;

namespace MovieSearch.Repository.Domain
{
    public class KinopoistRelatedMovies
    {
        [Key]
        public long Id { get; set; }
        public long RelatedKinopoiskId { get; set; }
    }
}