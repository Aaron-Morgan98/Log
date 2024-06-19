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


		//[Route("/GameLog/GetAllGames")]
		[HttpGet]
		public async Task<ActionResult<List<GameEntity>>> GetAllGames()
		{
			var games = await _gameLogService.GetAllGamesAsync();
			return Ok(games);


		}


		//[Route($"GameLog/GetById/{id}")]
		[HttpGet]
		public async Task<IActionResult> GetGameById([FromRoute] int id)
		{
			var game = await _gameLogService.GetGameByIdAsync(id);

			if(game == null)
			{
				return NotFound();
			}
			else
			{
                return Ok(game);
            }
			
		}


		[HttpPost]
		public async Task<IActionResult> AddGame([FromBody] GameEntity game)
		{
			await _gameLogService.AddGameAsync(game);
			return Ok();
		}


		[HttpPut]
		public async Task<IActionResult> UpdateGame([FromBody] GameEntity game)
		{
			await _gameLogService.UpdateGameAsync(game);
			return Ok();
		}


		[HttpDelete]
		public async Task<IActionResult> DeleteGame([FromRoute] int id)
		{
			await _gameLogService.DeleteGameByIdAsync(id);
			return Ok();
		}
	}
}

