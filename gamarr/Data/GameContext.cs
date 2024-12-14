using Microsoft.EntityFrameworkCore;
using gamarr.Models;

namespace gamarr.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; } = null!; // Non-nullable fix

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=VideoGameDb;Username=postgre;Password=gamarr");
            }
        }
    }
}