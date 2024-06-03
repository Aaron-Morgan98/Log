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
                    DateReleased = "22/09/2011",
                    DateStarted = "01/02/2024",
                    DateCompleted = "15/03/2024",
                    Review = "Amazing difficulty. Bit confusing at times.",
                    Rating = 8
                });


            //TODO: add validation 
        }


    }
}

