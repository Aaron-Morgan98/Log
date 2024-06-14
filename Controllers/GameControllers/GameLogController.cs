using System;
using Microsoft.AspNetCore.Mvc;
using Entities;
using ServiceLayer.Interfaces;


namespace GameControllers
{
	
	public class GameLogController : Controller
	{
		private readonly IGameLogService _gameLogService;

		public GameLogController(IGameLogService gameLogService)
		{
			_gameLogService = gameLogService;
		}

		[Route("/GameLog/GetAllGames")]
		[HttpGet]
		public async Task<ActionResult<List<GameEntity>>> GetAllGames()
		{
			var games = await _gameLogService.GetAllGamesAsync();
			return Ok(games);


		}
	}
}

