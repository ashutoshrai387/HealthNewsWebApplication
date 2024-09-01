using HealthNewsWebApplication.Models;
using HealthNewsWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthNewsWebApplication.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsService _newsService;

        public NewsController(NewsService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IActionResult> Index(string category = "Health")
        {
            var articles = await _newsService.GetHealthNewsAsync(category);
            ViewData["SelectedCategory"] = category;

            // Debugging line to ensure articles are being fetched
            if (articles == null || !articles.Any())
            {
                Console.WriteLine("No articles found!");
            }

            return View(articles);
        }
    }
}
