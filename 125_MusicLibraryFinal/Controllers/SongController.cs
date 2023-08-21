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
               // .Include(f => f.PlaylistId)
                .Include(f=>f.Playlist)
                .ToList();
            return Ok(songs);
        }

    }
}
