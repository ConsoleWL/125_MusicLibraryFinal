using _125_MusicLibraryFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace _125_MusicLibraryFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>()
                .HasOne(f => f.Playlist)
                .WithMany(f => f.Songs)
                .HasForeignKey(f => f.PlaylistId);
        }
    }
}
