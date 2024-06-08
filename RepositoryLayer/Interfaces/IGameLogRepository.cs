﻿using System;
using Entities;

namespace RepositoryLayer.Interfaces
{
	public interface IGameLogRepository
	{
		Task<List<GameEntity>> GetAllGamesAsync();
		Task<GameEntity?> GetGameByIdAsync(int id);
		Task AddGameAsync(GameEntity game);
		Task UpdateGameAsync(GameEntity game);
		Task DeleteGameById(int id);

    }
}

