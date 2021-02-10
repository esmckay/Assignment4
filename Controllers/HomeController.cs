using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //Welcome page that lists out all of the restaurants that we want.
        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? FavDish = r.FavDish ?? "It's all tasty";
                string? phone = r.FavDish ?? "N/A";
                string? website = r.FavDish ?? "Coming soon!";

                restList.Add(string.Format("#{0}: {1}. Favorite dish: {2}. Located at this address: {3}. " +
                    "Here is there phone number: {4} and their website is: {5}", r.RestRanking, r.RestName, FavDish, 
                    r.RestAddress, phone, website));
            }

            return View(restList);
        }

        //Get method for suggestions page
        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        //Post method that makes sure that the page follows the rules we set out in the model
        [HttpPost]
        public IActionResult Suggestions(SuggestionResponse suggResponse)
        {
            if (ModelState.IsValid)
            {
                Storage.AddSuggestion(suggResponse);

                return View("Confirmation", suggResponse);
            }
            else
            {
                return View();
            }
            
            
        }

        public IActionResult SuggList()
        {
            return View(Storage.Suggestions);
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
