using MovieRatingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.ViewModels.Responses
{
    public class CreateMovieResponse
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"\d{4}", ErrorMessage = "Please insert a valid year.")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Movie Image File Name")]
        public string ImgCode { get; set; }

        [Required]
        public Director Director { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Actors")]
        public List<String> Actors { get; set; }
    }
}
