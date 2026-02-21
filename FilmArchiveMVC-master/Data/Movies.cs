using System.ComponentModel.DataAnnotations;

namespace FilmArchive.Data
{
    public class Movies
    {
        [Key]
        public int MovieID { get; set; }

        public required string Title { get; set; }

        public required int ReleaseYear { get; set; }

        public required int DurationMinutes { get; set; }

        public required string Language { get; set; }

        public required bool IsSeries { get; set; } = false;
    }
}
