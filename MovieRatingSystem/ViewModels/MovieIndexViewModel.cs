using MovieRatingSystem.Models;
using System.Collections.Generic;

namespace MovieRatingSystem.ViewModels
{
    public class MovieIndexViewModel
    {
        public List<Movie> Movies { get; set; }
        public string SearchString { get; set; }
    }
}
