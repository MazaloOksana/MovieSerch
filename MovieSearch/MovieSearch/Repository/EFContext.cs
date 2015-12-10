using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MovieSearch.Repository.Domain;

namespace MovieSearch.Repository
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Movie")
        {
        }

        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Genre> Genres { get; set; }
        
        public DbSet<KinopoistRelatedMovies> KinopoistRelatedMovies { get; set; }
        
        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieToGenre> MovieToGenres { get; set; } 
        
        public DbSet<MovieToPerson> MovieToPersons { get; set; }
        
        public DbSet<Person> Persons { get; set; }
        
        public DbSet<Posters> Posters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}