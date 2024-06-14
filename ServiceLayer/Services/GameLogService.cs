using System;
using ServiceLayer.Interfaces;
using DataLayer.Interfaces;
using Entities;
//using AutoMapper;

namespace ServiceLayer.Services
{
	public class GameLogService : IGameLogService
	{

		private readonly IGameLogRepository _gameLogRepository;
		//private readonly IMapper _mapper;

		public GameLogService(IGameLogRepository gameLogRepository)
		{
			_gameLogRepository = gameLogRepository;
			//_mapper = mapper;
		}

		public async Task<List<GameEntity>> GetAllGamesAsync()
		{
			var games = await _gameLogRepository.GetAllGamesAsync();
			return games;
			//return _mapper.Map<List<GameEntity>>(games);
		}


		public async Task<GameEntity> GetGameByIdAsync(int id)
		{
			var game = await _gameLogRepository.GetGameByIdAsync(id);
			return game;
			//return _mapper.Map<GameDto>(game);
		}

		//public async Task<GameEntity> AddGameAsync(GameEntity gameEntity)
		//{
		//	//var gameEntity = _mapper.Map<GameEntity>(gameDto);
		//	var result = await _gameLogRepository.AddGameAsync(gameEntity);

			 

		//	//return _mapper.Map<GameDto>(gameEntity);

		//}

		//public async Task<GameDto> UpdateGameAsync(GameDto gameDto)
		//{
		//	var gameEntity = _mapper.Map<GameEntity>(gameDto);
		//	await _gameLogRepository.UpdateGameAsync(gameEntity);

		//	return _mapper.Map<GameDto>(gameEntity);
		//}

		//public async Task DeleteGameByIdAsync(int id)
		//{
  //          await _gameLogRepository.DeleteGameByIdAsync(id);

  //      }
    }
}

