using _125_MusicLibraryFinal.Data;
using _125_MusicLibraryFinal.Models;
using _125_MusicLibraryFinal.Models.Dto;
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
        public IActionResult AddingASongWithoutPlaylist([FromBody] Song song)
        {
            if (song is null)
                return NotFound();

            _context.Songs.Add(song);   
            _context.SaveChanges();
            return Ok(song);
        }

        [HttpPut("{songid}/playlist/{playlistid}")]
        public IActionResult AssignSongToPlaylist(int songid, int playlistid)
        {
            Song? song = _context.Songs.FirstOrDefault(f => f.Id == songid);

            if (song is null)
                return NotFound();

            Playlist? playlist = _context.Playlists.FirstOrDefault(f => f.PlaylistId == playlistid);

            if (playlist is null)
                return NotFound();

            song.PlaylistId = playlistid;

            _context.SaveChanges();
            return Ok(song);
        }

        // Adding not existing song[From Body] to and Existing Playlist
        [HttpPost("{playlistId}")]
        public IActionResult CreatingASongAndAssigningTOTheList(int playlistId, [FromBody] Song song)
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

        //[HttpPatch("{id}")]
        //public IActionResult UpdatePartial(int id, [FromBody] SongDto songDto)
        //{
        //    if (songDto is null)
        //        return BadRequest();

        //    Song? existingSong = _context.Songs.SingleOrDefault(f => f.Id == id);

        //    if (existingSong is null)
        //        return NotFound($"No song with id {id}");

        //    existingSong = PatchSongObject(songDto);

        //    _context.SaveChanges();

        //    return Ok(existingSong);
        //}
        //private Song PatchSongObject(SongDto songDto)
        //{
        //    Song result = new Song();
        //    result.Title = songDto.Title;
        //    result.Artist = songDto.Artist;
        //    result.Album = songDto.Album;
        //    result.ReleaseDate = songDto.ReleaseDate;
        //    result.Genre = songDto.Genre;
        //    result.Likes = songDto.Likes;
        //    result.PlaylistId = songDto.PlaylistId;

        //    // here I stuck, I have no clue... because songDto Doesn't have Playlist because it was somekind of problem with constant looping
        //    // I leave it for now maybe I'll come back;
            
        //    //result.Playlist = new Playlist();

        //    return result; 
        //}

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
