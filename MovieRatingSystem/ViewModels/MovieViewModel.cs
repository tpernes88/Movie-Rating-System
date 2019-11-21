using MovieRatingSystem.Models;
using System.Collections.Generic;

namespace MovieRatingSystem.ViewModels
{
    public class MovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public string SearchString { get; set; }
    }
}
