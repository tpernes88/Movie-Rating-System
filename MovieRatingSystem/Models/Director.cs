using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Models
{
    public class Director
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Director")]
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
