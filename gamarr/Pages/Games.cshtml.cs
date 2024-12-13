using Microsoft.AspNetCore.Mvc.RazorPages;
using gamarr.Models;
using System.Collections.Generic;

namespace gamarr.Pages
{
    public class GamesModel : PageModel
    {
        public List<Game> Games { get; set; } = new List<Game>
        {
            new Game { Title = "The Legend of Zelda", Platform = "Switch", Genre = "Adventure", ReleaseDate = new System.DateTime(2017, 3, 3) },
            new Game { Title = "Halo Infinite", Platform = "Xbox", Genre = "Shooter", ReleaseDate = new System.DateTime(2021, 12, 8) }
        };

        public void OnGet()
        {
            // Logic for fetching games will go here in the future.
        }
    }
}