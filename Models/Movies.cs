namespace FilmArchive.Models
{
    public class Movies
    {
        public int MovieID { get; set; }

        public required string Title { get; set; }

        public required int ReleaseYear { get; set; }

        public required int DurationInMinutes { get; set; }

        public required bool IsSeries { get; set; } = false;

    }
}
