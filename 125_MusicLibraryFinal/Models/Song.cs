using System.ComponentModel.DataAnnotations.Schema;

namespace _125_MusicLibraryFinal.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime? ReleaseDate { get; set; } //20203-12-22
        public string? Genre { get; set; }
        public int Likes { get; set; }

        // navigational props
        [ForeignKey("Playlist")]
        public int? PlaylistId { get; set; }
        public Playlist? Playlist { get; set; }

    }
}
