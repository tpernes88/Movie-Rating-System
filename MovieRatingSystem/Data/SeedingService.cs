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

            Director d1 = new Director { Name = "John McTiernan"};
            Director d2 = new Director { Name = "Renny Harlin"};
            Director d3 = new Director { Name = "Steven Spielberg"};
            Director d4 = new Director { Name = "Frank Darabont"};

            Actor a1 = new Actor { Name = "Bruce Willis", MoviesActors = new List<MovieActor>() };
            Actor a2 = new Actor { Name = "Morgan Freeman", MoviesActors = new List<MovieActor>() };
            Actor a3 = new Actor { Name = "Ralph Fiennes", MoviesActors = new List<MovieActor>() };
            Actor a4 = new Actor { Name = "Ben Kingsley", MoviesActors = new List<MovieActor>() };
            Actor a5 = new Actor { Name = "Richard Attenborough", MoviesActors = new List<MovieActor>() };

            Movie m1 = new Movie { Name = "Die Hard", Year = 1988, Genre = g1, Director = d1, ImgCode = "dieHard.jpg", MoviesActors = new List<MovieActor>() };
            Movie m2 = new Movie { Name = "Die Hard2", Year = 1990, Genre = g1, Director = d2, ImgCode = "dieHard2.jpg", MoviesActors = new List<MovieActor>() };
            Movie m3 = new Movie { Name = "Jurassic Park", Year = 1993, Genre = g5, Director = d3, ImgCode = "jurassicPark.jpg", MoviesActors = new List<MovieActor>() };
            Movie m4 = new Movie { Name = "Schindler's List", Year = 1993, Genre = g2, Director = d3, ImgCode = "schindlersList.jpg", MoviesActors = new List<MovieActor>() };
            Movie m5 = new Movie { Name = "The Shawshank Redemption", Year = 1994, Genre = g2, Director = d4, ImgCode = "shawshank.jpg", MoviesActors = new List<MovieActor>() };

            MovieActor ma1 = new MovieActor { Actor = a1, Movie = m1 };
            MovieActor ma2 = new MovieActor { Actor = a1, Movie = m2 };
            MovieActor ma3 = new MovieActor { Actor = a2, Movie = m5 };
            MovieActor ma4 = new MovieActor { Actor = a3, Movie = m4 };
            MovieActor ma5 = new MovieActor { Actor = a4, Movie = m4 };
            MovieActor ma6 = new MovieActor { Actor = a5, Movie = m3 };

            m1.MoviesActors.Add(ma1);
            m2.MoviesActors.Add(ma2);
            m3.MoviesActors.Add(ma6);
            m4.MoviesActors.Add(ma4);
            m4.MoviesActors.Add(ma5);
            m5.MoviesActors.Add(ma3);

            _context.Genre.AddRange(g1, g2, g3, g4, g5);
            _context.Director.AddRange(d1, d2, d3, d4);
            _context.Actor.AddRange(a1, a2, a3, a4, a5);
            _context.Movie.AddRange(m1, m2, m3, m4, m5);
            _context.MovieActor.AddRange(ma1, ma2, ma3, ma4, ma5, ma6);

            _context.SaveChanges();
        }
    }
}
