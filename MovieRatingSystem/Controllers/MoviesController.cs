using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieRatingSystem.Models;
using MovieRatingSystem.ViewModels;

namespace MovieRatingSystem.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieRatingSystemDbContext _context;

        public MoviesController(MovieRatingSystemDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public IActionResult Index(MovieIndexViewModel movieViewModel)
        {
            movieViewModel.Movies = _context.Movie.Include(m => m.Genre).Include(m => m.Director).Include(m => m.MoviesActors).ToList();

            if (movieViewModel.SearchString != null)
            {
                var movies = movieViewModel.Movies;

                movieViewModel.Movies = movies.Where(m => m.Name.ToLower().Contains(movieViewModel.SearchString.ToLower())).ToList();
            }

            return View(movieViewModel);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.Include(m => m.Genre).Include(m => m.Director).Include(m => m.MoviesActors).ThenInclude(m => m.Actor).FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var concat = String.Join(';', movie.MoviesActors.Select(a => a.Actor.Name).ToArray());

            MovieDetailsViewModel viewModel = new MovieDetailsViewModel
            {
                Movie = movie,
                ActorsString = concat
            };

            return View(viewModel);
        }

        // GET: Movies/Creates
        public IActionResult Create()
        {
            var genres = _context.Genre.ToList();

            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View(viewModel);
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieFormViewModel movieViewModel)
        {
            if (ModelState.IsValid)
            {
                Movie movie = new Movie();

                var movieInDb = _context.Movie.SingleOrDefault(m => m.Name.ToLower().Trim() == movieViewModel.Name.ToLower().Trim());

                if (movieInDb != null)
                {
                    return RedirectToAction("Details", new { id = movieInDb.Id });
                }


                var directors = _context.Director.ToList();
                var actors = _context.Actor.ToList();

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Year,ImgCode")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
