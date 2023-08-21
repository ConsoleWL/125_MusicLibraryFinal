using _125_MusicLibraryFinal.Data;
using _125_MusicLibraryFinal.Models;
using Microsoft.AspNetCore.Mvc;
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
                .FirstOrDefault();

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
