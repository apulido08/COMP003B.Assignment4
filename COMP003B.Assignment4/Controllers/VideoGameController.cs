using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;



namespace COMP003B.Assignment4.Controllers
{
    public class VideoGamesController : Controller
    {
        public IActionResult Index()
        {
            var videoGames = new List<VideoGame>
        {
            new VideoGame { Id = 1, Title = "Quest of Legends", Genre = "RPG", Description = "Embark on epic quests in a magical realm.", ReleaseDate = new DateTime(2022, 5, 15) },
            new VideoGame { Id = 2, Title = "Pixel Racer", Genre = "Racing", Description = "Race through pixel-perfect tracks.", ReleaseDate = new DateTime(2023, 3, 1) }
        };

            return View(videoGames);
        }

        public IActionResult Details(int id)
        {
            var videoGame = new VideoGame { Id = id, Title = $"Game {id}", Genre = "Unknown", Description = "Detailed description coming soon.", ReleaseDate = DateTime.Now };
            return View(videoGame);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VideoGame game)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index"); 
            }

            return View(game);
        }
    }

}
