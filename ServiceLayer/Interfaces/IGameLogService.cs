using System;
using Entities;



namespace ServiceLayer.Interfaces

{
	public interface IGameLogService
	{
		Task<List<GameEntity>> GetAllGamesAsync();
		Task<GameEntity> GetGameByIdAsync(int id);
		//Task<GameDto> AddGameAsync(GameDto gameDto);
		//Task<GameDto> UpdateGameAsync(GameDto gameDto);
		//Task DeleteGameByIdAsync(int id);
		
	}
}

