using BestProvoRestaurants.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BestProvoRestaurants.Controllers
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
            //List<TopRestaurant> restaurantList = new List<TopRestaurant>();
            //foreach (TopRestaurant topR in TopRestaurant.GetTopRestaurants())
            //{
            //    restaurantList.Add(topR);
            //}
            //return View(restaurantList);
            List<string> restaurantList = new List<string>();

            foreach (TopRestaurant TopR in TopRestaurant.GetTopRestaurants())
            {
                if (TopR.FavoriteDish == "it\'s all tasty!")
                {
                    restaurantList.Add($"#{TopR.Rank}: {TopR.Name}, where {TopR.FavoriteDish} - {TopR.Address}, {TopR.Phone}, <a href=\"{ TopR.Website}\" target=\"_blank\">{TopR.Website}</a><br />");
                }
                else
                {
                    restaurantList.Add($"#{TopR.Rank}: {TopR.Name}, with the favorite dish \"{TopR.FavoriteDish}\" - {TopR.Address}, {TopR.Phone}, <a href=\"{ TopR.Website}\" target=\"_blank\">{TopR.Website}</a><br />");
                }
                
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult SuggestRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestRestaurant(UserRestaurant restaurant)
        {
            //if input is valid
            if (ModelState.IsValid)
            {
                //save data
                SuggestedRestaurantStorage.AddRestaurant(restaurant);
                //return view for confirmation of the added film
                return View("ListSuggestedRestaurants", SuggestedRestaurantStorage.ConcatSuggestRestaurants);
            }
            //if input is invalid
            else
            {
                //return current view
                return View();
            }
        }

        public IActionResult ListSuggestedRestaurants()
        {
            return View(SuggestedRestaurantStorage.ConcatSuggestRestaurants);
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
