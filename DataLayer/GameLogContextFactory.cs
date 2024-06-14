using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


//This file is needed so that migrations can occur at design time as well as run time

namespace DataLayer
{
	public class GameLogContextFactory : IDesignTimeDbContextFactory<GameLogContext>
	{
		public GameLogContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<GameLogContext>();

			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("GameLog");
			optionsBuilder.UseSqlite(connectionString);

			return new GameLogContext(optionsBuilder.Options);
		}
	}
}

