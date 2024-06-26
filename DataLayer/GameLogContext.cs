﻿using Microsoft.EntityFrameworkCore;
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
            //base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={DbPath}");
            }
  
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
                    Review = "Amazing difficulty and level design. Bit confusing at times.",
                    Rating = 8,
                    Difficulty = 9
                });
            modelBuilder.Entity<GameEntity>()
                .HasData(new GameEntity
                {
                    GameId = 2,
                    Title = "Kingdom Come: Deliverance",
                    DateReleased = "13/02/2018",                                    
                    Review = "Great open world and very immersive. Steep learning curve.",
                    Rating = 9,
                    Difficulty = 7
                });


            //TODO: add validation 
        }


    }
}

