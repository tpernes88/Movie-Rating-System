using MovieRatingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "The Year must have four digits.")]
        [MaxLength(4, ErrorMessage = "Invalid Year!")]
        public int Year { get; set; }

        [Required]
        public IEnumerable<Genre> Genres { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Movie Image File Name")]
        public string ImgCode { get; set; }

        [Required]
        public Director Director { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Actor")]
        public int ActorId { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
