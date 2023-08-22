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
            // So first tak it was ease to Seed Data Just for Song class but then when I tried to seed data in one to many ... it's very chellanging

            // there is another way to write from Playlist to songs... can be both ways
            modelBuilder.Entity<Song>()
                .HasOne(f => f.Playlist)
                .WithMany(f => f.Songs)
                .HasForeignKey(f => f.PlaylistId);

            modelBuilder.Entity<Playlist>()
                .HasData(
                new Playlist { PlaylistId = 1, Name = "Rok" },
                new Playlist { PlaylistId = 2, Name = "Pop" },
                new Playlist { PlaylistId = 3, Name = "Rap" }
                );

            modelBuilder.Entity<Song>()
                .HasData(                                                                  // Don't know how to insert datetime in here, so I left DateTime.Now
                new Song { Id = 1, Title = "Txt", Artist = "Arsm", Album = "Feedback", ReleaseDate = DateTime.Now, Genre = "Pop", Likes = 0, PlaylistId = 2},
                new Song { Id = 2, Title = "Migrations  ", Artist = "HasData", Album = "Todat", ReleaseDate = DateTime.Now, Genre = "Pop", Likes = 0, PlaylistId = 2 },
                new Song { Id = 3, Title = "Blog", Artist = "HasData", Album = "One ", ReleaseDate = DateTime.Now, Genre = "Rock", Likes = 0, PlaylistId = 1 },
                new Song { Id = 4, Title = "Thus  ", Artist = "See ", Album = "Custom ", ReleaseDate = DateTime.Now, Genre = "Rock", Likes = 0, PlaylistId = 1 },
                new Song { Id = 5, Title = "Note", Artist = "See ", Album = "Temporary ", ReleaseDate = DateTime.Now, Genre = "Rap", Likes = 0, PlaylistId = 3 },
                new Song { Id = 6, Title = "Additional ", Artist = "Limitations ", Album = "Therefore ", ReleaseDate = DateTime.Now, Genre = "Rap", Likes = 0, PlaylistId = 3 }
                );

            // I don't know how to assign songs to playlists =(


            //modelBuilder.Entity<Song>()
            //  .HasData(                                                                  
            //  new Song 
            //      { 
            //          Id = 1, 
            //          Title = "Txt", 
            //          Artist = "Arsm", 
            //          Album = "Feedback", 
            //          ReleaseDate = DateTime.Now, 
            //          Genre = "Pop", Likes = 0, 
            //          PlaylistId = 2,
            //          Playlist = new Playlist()
            //          {
            //              PlaylistId =1,
            //              Name = "Pop",
            //              Songs // and then  here I don't know what to do/// it's like from both ends I stuckin there....
            //          }
            //      }
            //  );


        }
    }
}
