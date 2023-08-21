namespace _125_MusicLibraryFinal.Models.Dto
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Genre { get; set; }
        public int Likes { get; set; }

        // navigational props
        public int? PlaylistId { get; set; }
    }
}
