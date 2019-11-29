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

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required]
        public string ImgCode { get; set; }

        [Required]
        public Director Director { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Actors")]
        public List<MovieActor> MoviesActors { get; set; }
        public List<Rating> Votes { get; set; }
    }
}
