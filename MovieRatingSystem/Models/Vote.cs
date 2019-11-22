using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public Movie Movie { get; set; }
    }
}
