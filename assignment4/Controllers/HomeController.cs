using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment4.Models;

namespace assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> Recs = new List<string>();
            foreach (RecommendationsModel r in RecommendationsModel.GetRecs())
            {
                Recs.Add(string.Format("<div class='description'><h3>#{0}</h3><h4><u>{1}</u></h4><p><u>Drew's Favorite Dish</u>: {2}</p><p><u>Address</u>: {3}</p><p><u>Phone</u>: <a href='tel:{4}'>{4}</a></p>{5}</div><div class='img-container'><img class='img' src='img/{6}' alt='yummm'></div>", r.RecNo, r.RecName, r.RecFav, r.RecAddress, r.RecPhone, r.RecWeb, r.RecPhoto));
            }
            return View(Recs);
        }

        [HttpGet("AddRestaurant")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("AddRestaurant")]
        public IActionResult Add(Suggestions model)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(model);
                return Redirect("/Home/List");
            }
            return View();
            
        }

        [HttpGet("ViewSuggestions")]
        public IActionResult List()
        {
            return View(TempStorage.suggestions);
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
