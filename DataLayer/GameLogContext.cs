using Microsoft.EntityFrameworkCore;
using Entities;
using System.IO;

namespace DataLayer
{
    public class GameLogContext : DbContext
    {
        public GameLogContext(DbContextOptions<GameLogContext> options) : base(options)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            DbPath = Path.Combine(currentDirectory, "gameLog.db");
        }

        public DbSet<GameEntity> GameLogs { get; set; }
        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={DbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameEntity>(entity =>
            {
                entity.HasKey(e => e.GameId);
                entity.Property(e => e.GameId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GameEntity>()
                .HasData(new GameEntity
                {
                    GameId = 1,
                    Title = "Dark Souls 1",
                    DateReleased = "22/09/2011",
                    Review = "Amazing world/level design, the majority of the world is interconnected. A lot of the side quests are very hidden/confusing, you need a guide majority of the time. Combat is amazing, movement is holding it back however. Both DLCs add difficulity and the fight with Artorias is so far my favourite in the DS series.",
                    Rating = 8,
                    Difficulty = 8,
                    Story = 9
                });

            modelBuilder.Entity<GameEntity>()
                .HasData(new GameEntity
                {
                    GameId = 2,
                    Title = "Dark Souls 2",
                    DateReleased = "13/02/2018",
                    Review = "A bit of a let down after DS 1. The level design is still great, but the combat is so slow (healing), the game was a bit of a chore to get through at the latter stages. ADP is a also an awful addition. DLCs lackluster, seemed like they were just thrown in.",
                    Rating = 6,
                    Difficulty = 7,
                    Story = 6
                });
             modelBuilder.Entity<GameEntity>()
                .HasData(new GameEntity
                {
                    GameId = 3,
                    Title = "Dark Souls 3",
                    DateReleased = "13/02/2018",
                    Review = "A great comback after DS2, level design is top tier, every area made me want to explore. The bosses were a major improvement over the last two games. The DLC here is also on par if not better than DS1 DLC. Story and lore is also interesting",
                    Rating = 9,
                    Difficulty = 8,
                    Story = 9
                });

            //TODO: add validation 
        }
    }
}
