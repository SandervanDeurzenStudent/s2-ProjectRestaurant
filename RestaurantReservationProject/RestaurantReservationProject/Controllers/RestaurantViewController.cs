using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Factories;
using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Restraurants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Presentation.models;

namespace Presentation.Controllers
{
    public class RestaurantViewController : Controller
    {
        private readonly Test _context;
        IRestaurantContainerLogic restaurantContainerLogic;
        ICommentContainerLogic commentContainerLogic;
        IRestaurantLogic restaurantLogic;
        
        public RestaurantViewController()
        {
            restaurantContainerLogic = RestaurantFactory.CreateRestaurantCollection();
            commentContainerLogic = CommentFactory.CreateCommentCollection();
            restaurantLogic = RestaurantFactory.CreateRestaurant();
        }
        // GET: Restaurant
        public async Task<IActionResult> Index()
        {
            List<RestaurantModel> restaurants = new List<RestaurantModel>();
            restaurantContainerLogic.GetList().ForEach(dto => restaurants.Add(new RestaurantModel(dto)));
            return View(restaurants);
        }

        // GET: Restaurant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //get the Comments of the restaurant
            commentContainerLogic.GetCommentsById(Convert.ToInt32(id));
         
            //get the restaurant
            return View(new RestaurantModel(restaurantContainerLogic.getRestaurantById(Convert.ToInt32(id))));
        }

        // GET: Restaurant/Create/restaurantId
        public IActionResult Create(int? id)
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Info,Address,Telephone,Email")] RestaurantModel restaurantModel)
        {
            if (ModelState.IsValid)
            {
                restaurantContainerLogic.create(restaurantModel.convertToLogic());
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        // GET: Restaurant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = restaurantContainerLogic.getRestaurantById((int)id);
            if (restaurantModel == null)
            {
                return NotFound();
            }
            return View(new RestaurantModel( restaurantModel));
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[FromForm] RestaurantModel restaurantModel)
        {
            if (id != restaurantModel.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    restaurantLogic.update((int)id, restaurantModel.convertToLogic());
                }
                catch (Exception)
                {
                    if (!RestaurantModelExists(restaurantModel.Id))
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        // GET: Restaurant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            restaurantContainerLogic.Delete(Convert.ToInt32(id));
            return Redirect("Index");
        }

        // POST: Restaurant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurantModel = await _context.RestaurantModel.FindAsync(id);
            _context.RestaurantModel.Remove(restaurantModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantModelExists(int id)
        {
            if (restaurantContainerLogic.getRestaurantById(id) == null) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
