using Microsoft.AspNetCore.Mvc;
using gamarr.Data;
using gamarr.Models;
using System.Linq;

namespace gamarr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameContext _context;

        public GameController(GameContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetGames()
        {
            var games = _context.Games.ToList();
            return Ok(games);
        }

        [HttpPost]
        public IActionResult AddGame([FromBody] Game game)
        {
            if (game == null)
            {
                return BadRequest("Game data is invalid.");
            }

            _context.Games.Add(game);
            _context.SaveChanges();
            return Ok(new { Message = "Game added successfully", Game = game });
        }
    }
}