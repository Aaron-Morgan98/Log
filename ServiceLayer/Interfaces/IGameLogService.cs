using System;
using DTOs;



namespace ServiceLayer.Interfaces

{
	public interface IGameLogService
	{
		Task<List<GameDto>> GetAllGamesAsync();
		Task<GameDto> GetGameByIdAsync(int id);
		Task<GameDto> AddGameAsync(GameDto gameDto);
		Task<GameDto> UpdateGameAsync(GameDto gameDto);
		Task DeleteGameByIdAsync(int id);
		
	}
}

