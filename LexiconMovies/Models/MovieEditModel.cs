using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LexiconMovies.Models
{
    public class MovieEditModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public List<string> Genres { get; set; }
    }
}