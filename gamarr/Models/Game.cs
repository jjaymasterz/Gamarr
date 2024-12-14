using System;

namespace gamarr.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; // Default initialization for non-nullable
        public string Platform { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string CoverImage { get; set; } = string.Empty;
    }
}