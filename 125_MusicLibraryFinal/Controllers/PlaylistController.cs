using _125_MusicLibraryFinal.Data;
using _125_MusicLibraryFinal.Models;
using _125_MusicLibraryFinal.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _125_MusicLibraryFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PlaylistController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Playlist> playlists = _context.Playlists
                .Include(f => f.Songs)
                .ToList();

            return Ok(playlists);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Playlist? playlist = _context.Playlists
                .Include(f => f.Songs)
                .FirstOrDefault(f => f.PlaylistId == id);

            if (playlist is null)
                return NotFound();

            return Ok(playlist);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PlaylistDto playlist)
        {
            if (playlist is null)
                return BadRequest();

            Playlist? newPlaylist = PostPlaylistObject(playlist);

            _context.Playlists.Add(newPlaylist);
            _context.SaveChanges();
            return Ok(newPlaylist);
        }

        // Helper Method to Take care of Post^
        private Playlist PostPlaylistObject(PlaylistDto playlistDto)
        {
            Playlist result = new Playlist();
            result.Name = playlistDto.Name;

            result.Songs = new List<Song>();

            // how to get read of that "possible null"
            playlistDto.Songs.ForEach(f =>
            {
                Song temp = new Song();
                temp.Title = f.Title;
                temp.Artist = f.Artist;
                temp.Album = f.Album;
                temp.ReleaseDate = f.ReleaseDate;
                temp.Genre = f.Genre;
                temp.Likes = f.Likes;

                result.Songs.Add(temp);
            });

            return result;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Playlist? playlist = _context.Playlists
                .Include(f => f.Songs)
                .FirstOrDefault(f => f.PlaylistId == id);

            if (playlist is null)
                return NotFound();

            _context.Playlists.Remove(playlist);
            _context.SaveChanges();
            return Ok(playlist);
        }
    }
}
