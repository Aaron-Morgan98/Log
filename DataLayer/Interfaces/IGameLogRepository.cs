using System;
using Entities;

namespace DataLayer.Interfaces
{
	public interface IGameLogRepository
	{
		Task<List<GameEntity>> GetAllGamesAsync();
		Task<GameEntity?> GetGameByIdAsync(int id);
		Task AddGameAsync(GameEntity game);
		Task UpdateGameAsync(GameEntity game);
		Task DeleteGameByIdAsync(int id);

    }
}

