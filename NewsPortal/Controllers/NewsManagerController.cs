using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsAPI;
using Microsoft.Extensions.Logging;
using NewsPortal.Models;
using NewsPortal.Areas.Identity.Data;
using NewsPortal.Data;

namespace NewsPortal.Controllers
{
    [Route("[controller]")]
    public class NewsManagerController : Controller
    {
        private readonly NewsApiClient myApi = new NewsApiClient("cf3a3b1786024ff69305a7ee40587b43");

        private readonly AppDbContext db;
        public NewsManagerController(AppDbContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<IActionResult> Get(RequestModel request, NewsModel news)
        {
            request.ArticleResult = myApi.GetEverything(new EverythingRequest
            {
                Q = request.Q,
                Domains = new List<string> { "championat.com", "sports.ru", "sportarena.by", "eurosport.ru", "football.ua", "soccer.ru", "sportmail.ru", "gazeta.ru", "tass.ru", "sportrbc.ru", "allhockey.ru", "khl.ru", "hockey-world.net", "nhl.com", "allbasketball.org", "nba.com", "slamdunk.ru", "AllBoxing.ru", "fightnews.info", "rusboxing.ru", "fighttime.ru", "gotennis.ru", "tennis.by", "rusbiathlon.ru", "biathlonworld.com", "CyberSport.ru", "igromania.ru", "cyber.sports.ru", "escorenews.com" },
                SortBy = request.SortBy,
                Language = request.Language,
                From = request.From
            });
            if (request.ArticleResult.Status == Statuses.Ok)
            {
                foreach(var article in request.ArticleResult.Articles)
                {
                    news.Id = db.NewsModels.Select(id => id.Id).OrderByDescending(id => id).Take(1).FirstOrDefault()+1;
                    news.Author = article.Author;
                    news.Description = article.Description;
                    news.Title = article.Title;
                    news.Url = article.Url;
                    news.PublishedAt = article.PublishedAt;
                    news.UrlToImage = article.UrlToImage;
                    db.NewsModels.Add(news); 
                    await db.SaveChangesAsync();
                }
                return View("GetAllNews",request);
            }
            else
            {
                return View("Error");
            }
            
        }

        [HttpGet]
        public IActionResult GetAllNews(RequestModel request)
        {
            var NewsList = new List<string> { "Бавария", "Манчестер сити", "Манчестер Юнайтед", "Боррусия", "Реал Мадрид", "Лига Чемпионов", "Барселона", "Севилья", "Ливерпуль", "ПСЖ", "Лига Европы" };
            var rnd = new Random();
            int number = rnd.Next(0, NewsList.Count);
            request.ArticleResult = myApi.GetEverything(new EverythingRequest
            {
                Q = $"{NewsList[number]}",
                Domains = new List<string> { "championat.com", "sports.ru", "sportarena.by", "eurosport.ru", "football.ua", "soccer.ru", "sportmail.ru", "gazeta.ru", "tass.ru", "sportrbc.ru", "allhockey.ru", "khl.ru", "hockey-world.net", "nhl.com", "allbasketball.org", "nba.com", "slamdunk.ru", "AllBoxing.ru", "fightnews.info", "rusboxing.ru", "fighttime.ru", "gotennis.ru", "tennis.by", "rusbiathlon.ru", "biathlonworld.com", "CyberSport.ru", "igromania.ru", "cyber.sports.ru", "escorenews.com" },
                SortBy = SortBys.Relevancy,
                Language = Languages.RU,
                From = DateTime.Now.AddDays(-29)
            });
            if (request.ArticleResult.Status == Statuses.Ok)
            {
                return View(request);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
