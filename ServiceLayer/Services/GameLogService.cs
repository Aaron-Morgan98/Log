using System;
using ServiceLayer.Interfaces;
using DataLayer.Interfaces;
using DTOs;
using Entities;
using AutoMapper;

namespace ServiceLayer.Services
{
	public class GameLogService : IGameLogService
	{

		private readonly IGameLogRepository _gameLogRepository;
		private readonly IMapper _mapper;

		public GameLogService(IGameLogRepository gameLogRepository, IMapper mapper)
		{
			_gameLogRepository = gameLogRepository;
			_mapper = mapper;
		}

		public async Task<List<GameDto>> GetAllGamesAsync()
		{
			var games = await _gameLogRepository.GetAllGamesAsync();
			return _mapper.Map<List<GameDto>>(games);
		}


		public async Task<GameDto> GetGameByIdAsync(int id)
		{
			var game = await _gameLogRepository.GetGameByIdAsync(id);
			return _mapper.Map<GameDto>(game);
		}

		public async Task<GameDto> AddGameAsync(GameDto gameDto)
		{
			var gameEntity = _mapper.Map<GameEntity>(gameDto);
			await _gameLogRepository.AddGameAsync(gameEntity);

			return _mapper.Map<GameDto>(gameEntity);

		}

		public async Task<GameDto> UpdateGameAsync(GameDto gameDto)
		{
			var gameEntity = _mapper.Map<GameEntity>(gameDto);
			await _gameLogRepository.UpdateGameAsync(gameEntity);

			return _mapper.Map<GameDto>(gameEntity);
		}

		public async Task DeleteGameByIdAsync(int id)
		{
            await _gameLogRepository.DeleteGameByIdAsync(id);

        }
    }
}

