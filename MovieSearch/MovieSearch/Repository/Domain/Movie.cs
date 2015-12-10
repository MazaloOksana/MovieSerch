using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieSearch.Repository.Domain
{
    public class Movie
    {
        public Movie()
        {
            this.MovieToPerson = new HashSet<MovieToPerson>();
            this.Posters = new HashSet<Posters>();
            this.MovieToGenre = new HashSet<MovieToGenre>();
        }

        public Movie(Guid movieId, string originalTitle, string russianTitle, long? kinopoiskId, string description, DateTime? releaseDate, byte? ageLimit, string mpaa, int? runtime)
        {
            Id = movieId;
            OriginalTitle = originalTitle;
            RussianTitle = russianTitle;
            KinopoiskId = kinopoiskId;
            Description = description;
            ReleaseDate = releaseDate;
            AgeLimit = ageLimit;
            MPAA = mpaa;
            Runtime = runtime;
        }

        [Key]
        public Guid Id { get; set; }
        public string OriginalTitle { get; set; }
        public string RussianTitle { get; set; }
        public long? KinopoiskId { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public byte? AgeLimit { get; set; }
        public string MPAA { get; set; }
        public int? Runtime { get; set; }

        public virtual ICollection<MovieToPerson> MovieToPerson { get; set; }
        
        public virtual ICollection<Posters> Posters { get; set; }
        
        public virtual ICollection<MovieToGenre> MovieToGenre { get; set; }
    }
}