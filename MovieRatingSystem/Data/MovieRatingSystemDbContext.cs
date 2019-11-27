using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieRatingSystem.Models
{
    public class MovieRatingSystemDbContext : DbContext
    {
        public MovieRatingSystemDbContext (DbContextOptions<MovieRatingSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieActor> MovieActor { get; set; }
        public DbSet<Rating> Vote { get; set; }

    }
}
