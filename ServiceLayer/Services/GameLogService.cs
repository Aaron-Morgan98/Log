using System;
using ServiceLayer.Interfaces;
using DataLayer.Interfaces;
using Entities;


namespace ServiceLayer.Services
{
	public class GameLogService : IGameLogService
	{

		private readonly IGameLogRepository _gameLogRepository;
		

		public GameLogService(IGameLogRepository gameLogRepository)
		{
			_gameLogRepository = gameLogRepository;
			
		}

		public async Task<List<GameEntity>> GetAllGamesAsync()
		{
			var games = await _gameLogRepository.GetAllGamesAsync();
			return games;
			
		}


		public async Task<GameEntity> GetGameByIdAsync(int id)
		{
			var game = await _gameLogRepository.GetGameByIdAsync(id);
			return game;
			
		}

		public async Task AddGameAsync(GameEntity game)
		{
			await _gameLogRepository.AddGameAsync(game);
			
		}


		public async Task UpdateGameAsync(GameEntity game)
		{

			await _gameLogRepository.UpdateGameAsync(game);

			
		}



		public async Task DeleteGameByIdAsync(int id)
		{
			await _gameLogRepository.DeleteGameByIdAsync(id);

		}
	}
}

