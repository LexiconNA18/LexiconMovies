using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LexiconMovies.Models
{
    public class LexiconMoviesContext : DbContext
    {
        public LexiconMoviesContext(DbContextOptions<LexiconMoviesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Movie>()
               .HasData(
                    new Movie { Id = 1, Title = "AI", Genre = "Science Fiction", Price = 140, ReleaseDate = DateTime.Parse("2002-01-01") },
                    new Movie { Id = 2, Title = "AI FTW", Genre = "Comedy", Price = 120, ReleaseDate = DateTime.Parse("2018-06-22") },
                    new Movie { Id = 3, Title = "Generations", Genre = "Drama", Price = 160, ReleaseDate = DateTime.Parse("2009-04-15") },
                    new Movie { Id = 4, Title = "Return of the Killer Penguins", Genre = "Splatter", Price = 80, ReleaseDate = DateTime.Parse("1989-10-12") },
                    new Movie { Id = 5, Title = "Killer Penguins from Space", Genre = "Splatter", Price = 60, ReleaseDate = DateTime.Parse("1964-11-01") }
                );

            
        }
        
        public DbSet<Movie> Movie { get; set; }
    }
}
