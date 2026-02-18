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
            FilmArchiveContext context = new();
            IEnumerable<Movies> movies = context.Movie.ToList()
            .Select(m => new Movies
            {
                MovieID = m.MovieID,
                Title = m.Title,
                ReleaseYear = m.ReleaseYear,
                DurationInMinutes = m.DurationInMinutes,
                IsSeries = m.IsSeries
            }).ToList();

            return View(context);

        }
    }

}
