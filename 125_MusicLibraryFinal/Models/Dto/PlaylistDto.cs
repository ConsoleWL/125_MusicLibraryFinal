namespace _125_MusicLibraryFinal.Models.Dto
{
    public class PlaylistDto
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }

        //Navigational props
        public List<Song>? Songs { get; set; }
    }
}





