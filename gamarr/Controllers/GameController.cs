using Microsoft.AspNetCore.Mvc;

namespace gamarr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetGames()
        {
            return Ok(new { Message = "Retrieve all games" });
        }

        [HttpPost]
        public IActionResult AddGame([FromBody] object game)
        {
            return Ok(new { Message = "Game added successfully", Game = game });
        }
    }
}