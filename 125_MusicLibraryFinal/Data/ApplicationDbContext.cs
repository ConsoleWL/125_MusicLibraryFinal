using Microsoft.EntityFrameworkCore;

namespace _125_MusicLibraryFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
