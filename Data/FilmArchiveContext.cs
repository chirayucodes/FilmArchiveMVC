using Microsoft.EntityFrameworkCore;
using FilmArchive.Models;

namespace FilmArchive.Data
{
    public class FilmArchiveContext : DbContext
    {
        public FilmArchiveContext()
        {
        }

        public FilmArchiveContext(DbContextOptions<FilmArchiveContext> options)
            : base(options)
        {
        }
        public DbSet<Movies> Movie { get; set; }
    }
}