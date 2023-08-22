using _125_MusicLibraryFinal.Data;
using _125_MusicLibraryFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace _125_MusicLibraryFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Song> songs = _context.Songs
                .Include(f=>f.Playlist)
                .ToList();
            return Ok(songs);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Song? song = _context.Songs
                .Include(f=>f.Playlist)
                .FirstOrDefault(f=>f.Id == id);

            if (song is null)
                return NotFound();

            return Ok(song);
        }

        // Adding a song wihtout adding it to the Playlist
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            if (song is null)
                return NotFound();

            _context.Songs.Add(song);   
            _context.SaveChanges();
            return Ok(song);
        }

        // Adding not existing song[From Body] to and Existing Playlist
        [HttpPost("{playlistId}")]
        public IActionResult Post(int playlistId, [FromBody] Song song)
        {
            if (song is null)
                return NotFound();

            Playlist? playlist = _context.Playlists.FirstOrDefault(f => f.PlaylistId == playlistId);

            if (playlist is null)
                return NotFound($"Not found playlist id {playlistId}");

            song.PlaylistId = playlistId;
            song.Playlist = playlist;

            //playlist.Songs.Add(song);

            _context.Songs.Add(song);
            _context.SaveChanges();
            return Ok(song);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song songUpdate)
        {
            if (songUpdate is null)
                return BadRequest();

            Song? song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound();

            song.Title = songUpdate.Title;
            song.Artist = songUpdate.Artist;
            song.Album = songUpdate.Album;
            song.ReleaseDate = songUpdate.ReleaseDate;
            song.Genre = songUpdate.Genre;
            song.Likes = songUpdate.Likes;
            song.PlaylistId = songUpdate.PlaylistId;
            song.Playlist = song.Playlist; // is that right? looks fishy to me...

            _context.SaveChanges();
            return Ok(song);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Song? song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound();

            _context.Songs.Remove(song);
            _context.SaveChanges();
            return Ok(song);
        }

    }
}
