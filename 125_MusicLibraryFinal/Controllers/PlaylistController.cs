using _125_MusicLibraryFinal.Data;
using _125_MusicLibraryFinal.Models;
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

        

    }
}
