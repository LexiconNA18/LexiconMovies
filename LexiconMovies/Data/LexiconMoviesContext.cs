using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LexiconMovies.Models
{
    public class LexiconMoviesContext : DbContext
    {
        public LexiconMoviesContext (DbContextOptions<LexiconMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
