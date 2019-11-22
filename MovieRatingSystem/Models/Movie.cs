using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Actors")]
        public List<MovieActor> MoviesActors { get; set; }
        public List<Vote> Votes { get; set; }
    }
}
