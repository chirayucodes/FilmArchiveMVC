using Microsoft.AspNetCore.Mvc;

namespace FilmArchive.Controllers
{
    public async Task<IActionResult> Index()
    {
        var movies = await _context.Movies.ToListAsync();
        return View(movies);
    }
}
