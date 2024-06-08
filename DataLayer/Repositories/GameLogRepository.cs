using System;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Entities;
using DataLayer.Interfaces;


namespace DataLayer.Repositories
{
	public class GameLogRepository : IGameLogRepository
	{
		private readonly GameLogContext _context;

		public GameLogRepository(GameLogContext context)
		{
			_context = context;
		}


		//GET all 
		public async Task<List<GameEntity>> GetAllGamesAsync()
		{
			var result = await _context.GameLogs.ToListAsync();
			return result;
		}

		//GET by id
		public async Task<GameEntity?> GetGameByIdAsync(int id)
		{
			var result = await _context.GameLogs
								.SingleOrDefaultAsync(b => b.GameId == id);
			return result;
		}

		//CREATE
		public async Task AddGameAsync(GameEntity game)
		{
			await _context.GameLogs.AddAsync(game);
			await _context.SaveChangesAsync();
		}

		//UPDATE
		public async Task UpdateGameAsync(GameEntity game)
		{
			var result = await _context.GameLogs
							.SingleOrDefaultAsync(b => b.GameId == game.GameId);

			if(result != null)
			{
				result.Title = game.Title;
				result.DateReleased = game.DateReleased;
				result.DateStarted = game.DateStarted;
				result.DateCompleted = game.DateCompleted;
				result.Review = game.Review;
				result.Rating = game.Rating;
				await _context.SaveChangesAsync();
			}
		}


		//DELETE
		public async Task DeleteGameByIdAsync(int id)
		{
			var result = await _context.GameLogs.FindAsync(id);
			if(result != null)
			{
				_context.GameLogs.Remove(result);
				await _context.SaveChangesAsync();
            }
			else
			{
				throw new ArgumentException("No Game Log found with the specfied ID.");
			}
		}

	}
}

