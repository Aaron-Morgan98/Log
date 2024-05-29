using Microsoft.EntityFrameworkCore;
using Entities;
using System.IO;

namespace DataLayer
{
    public class GameLogContext : DbContext
    {
        public GameLogContext()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            DbPath = Path.Combine(currentDirectory, "gameLog.db");
        }

        public DbSet<GameEntity> GameEntities { get; set; }
        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameEntity>()
                .HasData(new GameEntity
                {
                    GameId = 1,
                    Title = "Dark Souls 1",
                    DateReleased = new DateOnly(2011, 9, 22),
                    DateStarted = new DateOnly(2024, 2, 1),
                    DateCompleted = new DateOnly(2024, 3, 15),
                    Review = "Amazing difficulty. Bit confusing at times.",
                    Rating = 8
                });


            //TODO: add validation 
        }


    }
}

