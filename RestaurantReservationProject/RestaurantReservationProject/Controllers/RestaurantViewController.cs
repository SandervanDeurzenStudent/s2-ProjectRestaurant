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
using Presentation.Models;

namespace Presentation.Controllers
{
    public class RestaurantViewController : Controller
    {
        private readonly Test _context;
        IRestaurantContainerLogic _restaurantContainerLogic;
        ICommentContainerLogic commentContainerLogic;
        IRestaurantLogic restaurantLogic;
        RestaurantConverter.RestaurantViewConverter restaurantViewConverter;
        RestaurantContainer r = new RestaurantContainer();
        public RestaurantViewController(IRestaurantContainerLogic restaurantContainerLogic)
        {
            //restaurantContainerLogic = IRESTCONTLGIC;
            //commentContainerLogic = CommentFactory.CreateCommentCollection();
            //restaurantLogic = RestaurantFactory.CreateRestaurant();
            restaurantViewConverter = new RestaurantConverter.RestaurantViewConverter();
            _restaurantContainerLogic =  restaurantContainerLogic;
        }
        
        // GET: Restaurant
        public IActionResult Index()
        {
            IndexRestaurantViewModel indexRestaurantViewModel = new IndexRestaurantViewModel
            {
                restaurantList = restaurantViewConverter.Convert_To_RestaurantViewModel(_restaurantContainerLogic.GetList())
            };
            
            return View(indexRestaurantViewModel);
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
            return View(new RestaurantViewModel(_restaurantContainerLogic.getRestaurantById(Convert.ToInt32(id))));
        }

        // GET: Restaurant/Create/restaurantId
        public IActionResult Create(int? id)
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        
        public IActionResult Create( RestaurantViewModel restaurantModel)
        {
            if (ModelState.IsValid)
            {
                _restaurantContainerLogic.create(restaurantModel.convertToLogic());
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = _restaurantContainerLogic.getRestaurantById((int)id);
            if (restaurantModel == null)
            {
                return NotFound();
            }
            return View(new RestaurantViewModel( restaurantModel));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[FromForm] RestaurantViewModel restaurantModel)
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
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _restaurantContainerLogic.Delete(Convert.ToInt32(id));
            return Redirect("Index");
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurantModel = await _context.RestaurantModel.FindAsync(id);
            _context.RestaurantModel.Remove(restaurantModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantModelExists(int id)
        {
            if (_restaurantContainerLogic.getRestaurantById(id) == null) 
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
