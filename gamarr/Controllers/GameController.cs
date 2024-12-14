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
    }
}