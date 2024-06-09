using System;
using Microsoft.AspNetCore.Mvc;
using DTOs;
using ServiceLayer.Interfaces;


namespace GameControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameLogController : ControllerBase
	{
		private readonly IGameLogService _gameLogService;

		public GameLogController(IGameLogService gameLogService)
		{
			_gameLogService = gameLogService;
		}

		[HttpGet]
		public async Task<ActionResult<List<GameDto>>> GetAllGames()
		{
			var games = await _gameLogService.GetAllGamesAsync();
			return Ok(games);
		}
	}
}

