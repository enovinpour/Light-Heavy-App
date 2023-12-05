using GymApp.Services.Interfaces;
using GymApp.Services.Services.News;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Website.Controllers
{
    [ApiController]
    [Route("/api/news")]
    public class NewsController : Controller
    {
        public INewsService newsService { get; set; }
        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        [HttpGet("getNews")]
        public async Task<IActionResult> GetNews()
        {
            var articles = await newsService.GetNews();

            return Ok(articles);
        }
    }
}
