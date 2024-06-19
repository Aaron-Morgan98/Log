using System;
using Entities;



namespace ServiceLayer.Interfaces

{
	public interface IGameLogService
	{
		Task<List<GameEntity>> GetAllGamesAsync();
		Task<GameEntity> GetGameByIdAsync(int id);
		Task AddGameAsync(GameEntity gameEntity);
		Task UpdateGameAsync(GameEntity game);
		Task DeleteGameByIdAsync(int id);

	}
}

