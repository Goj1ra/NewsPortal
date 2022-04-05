using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsPortal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewsApiClient myApi = new NewsApiClient("cf3a3b1786024ff69305a7ee40587b43");

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(RequestModel request,string typeOfSport)
        {
            var NewsList = new List<string> { "Бавария", "Манчестер сити", "Манчестер Юнайтед", "Боррусия", "Реал Мадрид", "Лига Чемпионов", "Барселона", "Севилья", "Ливерпуль", "ПСЖ", "Лига Европы", "АПЛ", "Серия А", "Бундеслига", "Лига 1", "Ла Лига" };
            var rnd = new Random();
            int numberFootball = rnd.Next(0, NewsList.Count);
            if (typeOfSport != null)
            {
                request.ArticleResult = myApi.GetEverything(new EverythingRequest
                {
                    Q = typeOfSport,
                    Domains = new List<string> { "championat.com", "sports.ru", "sportarena.by", "eurosport.ru", "football.ua", "soccer.ru", "sportmail.ru", "gazeta.ru", "tass.ru", "sportrbc.ru", "allhockey.ru", "khl.ru", "hockey-world.net", "nhl.com", "allbasketball.org", "nba.com", "slamdunk.ru", "AllBoxing.ru", "fightnews.info", "rusboxing.ru", "fighttime.ru", "gotennis.ru", "tennis.by", "rusbiathlon.ru", "biathlonworld.com", "CyberSport.ru", "igromania.ru", "cyber.sports.ru", "escorenews.com" },
                    SortBy = SortBys.Popularity,
                    Language = Languages.RU,
                    From = DateTime.Now.AddDays(-25)
                });

                if (request.ArticleResult.Status == Statuses.Ok)
                {
                    return PartialView(@"~/Views/Home/_IndexPartial.cshtml", request);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                request.ArticleResult = myApi.GetEverything(new EverythingRequest
                {
                    Q = $"{NewsList[numberFootball]}",
                    Domains = new List<string> { "championat.com", "sports.ru", "sportarena.by", "eurosport.ru", "football.ua", "soccer.ru", "sportmail.ru", "gazeta.ru", "tass.ru", "sportrbc.ru", "allhockey.ru", "khl.ru", "hockey-world.net", "nhl.com", "allbasketball.org", "nba.com", "slamdunk.ru", "AllBoxing.ru", "fightnews.info", "rusboxing.ru", "fighttime.ru", "gotennis.ru", "tennis.by", "rusbiathlon.ru", "biathlonworld.com", "CyberSport.ru", "igromania.ru", "cyber.sports.ru", "escorenews.com" },
                    SortBy = SortBys.Popularity,
                    Language = Languages.RU,
                    From = DateTime.Now.AddDays(-29)
                });
                if (request.ArticleResult.Status == Statuses.Ok)
                {
                    return View(request);
                }
                else
                {
                    return View();
                }
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
