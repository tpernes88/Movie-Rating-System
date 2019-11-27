using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
