using System;
using Microsoft.AspNetCore.Mvc;
using DTOs;
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
		public async Task<ActionResult<List<GameDto>>> GetAllGames()
		{
			var games = await _gameLogService.GetAllGamesAsync();
			return Ok(games);


		}
	}
}

