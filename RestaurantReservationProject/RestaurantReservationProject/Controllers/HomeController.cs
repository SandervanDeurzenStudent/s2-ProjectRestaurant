using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.models;
using RestaurantReservationProject.Models;

namespace RestaurantReservationProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //Restaurants
        public IActionResult RestaurantShow()
        {
           // BusinessLogic.Restraurants.RestaurantCollection l = new BusinessLogic.Restraurants.RestaurantCollection();
            
            return View();
        }
        public IActionResult Update(int? id)
        {
           // BusinessLogic.Restraurants.RestaurantCollection RDC = new BusinessLogic.Restraurants.RestaurantCollection();
            return View();
        }
        public IActionResult UpdateRestaurant(int? id, RestaurantViewModel restaurant)
        {
            return RedirectToAction("RestaurantShow");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult DeleteRestaurant(int? id)

        {
            //id is meegegeven URL id

            if (id == null)
            {
                return NotFound();
            }

            //BusinessLogic.Restraurants.RestaurantCollection RDC = new BusinessLogic.Restraurants.RestaurantCollection();
            //RDC.Delete(Convert.ToInt32(id));

            return RedirectToAction("RestaurantShow");
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateRestaurant(RestaurantViewModel restaurant)
        {
            //BusinessLogic.Restraurants.RestaurantCollectionController RDC = new BusinessLogic.Restraurants.RestaurantCollectionController();
            //RDC.create(restaurant);
            return Redirect("Restaurant");
        }
        public IActionResult RestaurantInfo(int? id)
        {
            //BusinessLogic.Restraurants.RestaurantCollection RDC = new BusinessLogic.Restraurants.RestaurantCollection();
            return View();
        }
        
        
        //USERS
        public IActionResult ShowUsers()
        {
            return View();
        }
    }
}
