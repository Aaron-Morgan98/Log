using System;
using Entities;
using DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
	public static class GameMapping
	{

		//DTO to Entity
		public static GameEntity ToEntity(this GameInformationDto game)
		{
			return new GameEntity()
			{
				GameId = game.GameId,
				Title = game.Title,
				DateReleased = game.DateReleased,
				DateStarted = game.DateStarted,
				DateCompleted = game.DateCompleted,
				Review = game.Review,
				Rating = game.Rating

			};

		}

		//Entity to DTO
		public static GameInformationDto ToGameInformationDto(this GameEntity game)
		{
			return new(
				game.GameId,
				game.Title,
				game.DateReleased,
				game.DateStarted,
				game.DateCompleted,
				game.Review,
				game.Rating
				);
		}
	}
}

