using Microsoft.AspNetCore.Mvc;
using gamarr.Models;
using System.Collections.Generic;

namespace gamarr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game>
        {
            new Game { Title = "The Legend of Zelda", Platform = "Switch", Genre = "Adventure", ReleaseDate = new System.DateTime(2017, 3, 3) },
            new Game { Title = "Halo Infinite", Platform = "Xbox", Genre = "Shooter", ReleaseDate = new System.DateTime(2021, 12, 8) }
        };

        [HttpGet]
        public IActionResult GetGames()
        {
            return Ok(games);
        }

        [HttpPost]
        public IActionResult AddGame([FromBody] Game game)
        {
            games.Add(game);
            return Ok(new { Message = "Game added successfully", Game = game });
        }
    }
}