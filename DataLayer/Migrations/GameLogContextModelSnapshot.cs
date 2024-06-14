﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(GameLogContext))]
    partial class GameLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("Entities.GameEntity", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateCompleted")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateReleased")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateStarted")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Review")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GameId");

                    b.ToTable("GameLogs");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            DateCompleted = "15/03/2024",
                            DateReleased = "22/09/2011",
                            DateStarted = "01/02/2024",
                            Rating = 8,
                            Review = "Amazing difficulty. Bit confusing at times.",
                            Title = "Dark Souls 1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
