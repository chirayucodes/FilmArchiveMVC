namespace FilmArchive.Models
{
    public class MoviesViewModel
    {
        public int MovieID { get; set; }

        public required string Title { get; set; }

        public required int ReleaseYear { get; set; }

        public required int DurationMinutes { get; set; }

        public required string Language { get; set; }

        public required bool IsSeries { get; set; } = false;

        public string? NetflixUrl { get; set; }
        public string? PrimeUrl { get; set; }
        public string? HotstarUrl { get; set; }


    }
}
