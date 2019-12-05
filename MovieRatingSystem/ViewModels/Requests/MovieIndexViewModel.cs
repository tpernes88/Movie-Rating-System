using MovieRatingSystem.Models;
using System.Collections.Generic;

namespace MovieRatingSystem.ViewModels.Requests
{
    public class MovieIndexViewModel
    {
        public List<Movie> Movies { get; set; }
        public string SearchString { get; set; }
    }
}
