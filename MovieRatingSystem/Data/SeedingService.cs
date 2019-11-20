using MovieRatingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Data
{
    public class SeedingService
    {
        public MovieRatingSystemDbContext _context;

        public SeedingService(MovieRatingSystemDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Movie.Any() || _context.Director.Any() ||
               _context.Actor.Any() || _context.Genre.Any() ||
               _context.MovieActor.Any())
            {
                return;
            }

            Genre g1 = new Genre { Name = "Action" };
            Genre g2 = new Genre { Name = "Drama" };
            Genre g3 = new Genre { Name = "Comedy" };
            Genre g4 = new Genre { Name = "Documentary" };
            Genre g5 = new Genre { Name = "Sci-Fi" };

            

        }
    }
}
