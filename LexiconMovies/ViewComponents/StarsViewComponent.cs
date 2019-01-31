using LexiconMovies.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMovies.ViewComponents
{
    public class StarsViewComponent : ViewComponent
    {
        private LexiconMoviesContext db;

        public StarsViewComponent(LexiconMoviesContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int movieId) {
            var movie = await db.Movie.FindAsync(movieId);
            var rating = movie.Rating;

            return View(rating);
        }
    }
}
