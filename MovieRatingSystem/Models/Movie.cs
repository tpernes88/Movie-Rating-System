using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public string ImgCode { get; set; }
        public Director Director { get; set; }
        public List<MovieActor> MoviesActors { get; set; }
    }
}
