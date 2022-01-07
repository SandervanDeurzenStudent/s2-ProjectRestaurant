using System;
using System.Threading.Tasks;
using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Restraurants;
using Microsoft.AspNetCore.Mvc;
using Presentation.Converter;
using Presentation.models;
using Presentation.Models;
using Presentation.RestaurantConverter;

namespace Presentation.Controllers
{
    public class RestaurantViewController : Controller
    {
        //restaurants
        IRestaurantContainerLogic _restaurantContainerLogic;
        IRestaurantLogic _restaurantLogic;
        //comments
        ICommentContainerLogic _commentContainerLogic;
        //Converters
        CommentViewConverter _commentViewConverter = new CommentViewConverter();
        RestaurantViewConverter _restaurantViewConverter = new RestaurantViewConverter();
        public RestaurantViewController(IRestaurantContainerLogic restaurantContainerLogic, ICommentContainerLogic commentContainerLogic, IRestaurantLogic restaurantLogic)
        {
            _restaurantContainerLogic = restaurantContainerLogic;
            _commentContainerLogic = commentContainerLogic;
            _restaurantLogic = restaurantLogic;
        }

        public IActionResult Index()
        {
            IndexRestaurantViewModel indexRestaurantViewModel = new IndexRestaurantViewModel
            {
                restaurantList = _restaurantViewConverter.Convert_To_RestaurantViewModel(_restaurantContainerLogic.GetList())
            };

            return View(indexRestaurantViewModel);
        }

        public IActionResult Details(int? id)
        {
            //get the Comments of the restaurant
            IndexCommentViewModel indexCommentViewModel = new IndexCommentViewModel
            {
                commentList = _commentViewConverter.Convert_To_CommentViewModel(_commentContainerLogic.GetCommentsById(Convert.ToInt32(id)))
            };

            var restaurant = new RestaurantViewModel(_restaurantContainerLogic.getRestaurantById(Convert.ToInt32(id)));
            IndexViewModel indexViewModel = new IndexViewModel();
            indexViewModel.restaurantModel = restaurant;
            indexViewModel.commentList = indexCommentViewModel.commentList;
            //get the restaurant
            return View(indexViewModel);
        }

        public IActionResult Create(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create( RestaurantViewModel restaurantModel)
        {
            if (ModelState.IsValid)
            {
                _restaurantContainerLogic.create(_restaurantViewConverter.Convert_To_Restaurant(restaurantModel));
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var restaurantModel = _restaurantContainerLogic.getRestaurantById((int)id);
            return View(new RestaurantViewModel( restaurantModel));
        }

        [HttpPost]
        public IActionResult Edit(int id,[FromForm] RestaurantViewModel restaurantModel)
        {
            try
            {
                _restaurantLogic.update(id, _restaurantViewConverter.Convert_To_Restaurant(restaurantModel));
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

        public async Task<IActionResult> Delete(int? id)
        {
            _restaurantContainerLogic.Delete(Convert.ToInt32(id));
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
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
