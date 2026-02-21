using FilmArchive.Data;
using FilmArchive.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmArchive.Controllers
{
    public class MovieController : Controller
    {
        private readonly FilmArchiveContext _context;
        public MovieController(FilmArchiveContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            IEnumerable<MoviesViewModel> movies = _context.Movies
            .Select(m => new MoviesViewModel
            {
                MovieID = m.MovieID,
                Title = m.Title,
                ReleaseYear = m.ReleaseYear,
                DurationMinutes = m.DurationMinutes,
                Language= m.Language,
                IsSeries = m.IsSeries
            }).ToList();

            return View(movies);

        }

      
    }

}
