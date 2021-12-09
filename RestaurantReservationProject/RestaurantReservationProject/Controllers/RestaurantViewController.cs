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
        //comments
        ICommentContainerLogic _commentContainerLogic;
        //Converters
        CommentViewConverter _commentViewConverter;
        RestaurantViewConverter _restaurantViewConverter;

        public RestaurantViewController(IRestaurantContainerLogic restaurantContainerLogic, ICommentContainerLogic commentContainerLogic, RestaurantViewConverter restaurantViewConverter, CommentViewConverter commentViewConverter)
        {
            _restaurantContainerLogic =  restaurantContainerLogic;
            _restaurantViewConverter = restaurantViewConverter;
            _commentContainerLogic = commentContainerLogic;
            _commentViewConverter = commentViewConverter;
        }

        public IActionResult Index()
        {
            IndexRestaurantViewModel indexRestaurantViewModel = new IndexRestaurantViewModel
            {
                restaurantList = _restaurantViewConverter.Convert_To_RestaurantViewModel(_restaurantContainerLogic.GetList())
            };
            return View(indexRestaurantViewModel);
        }
        public async Task<IActionResult> Details(int? id)
        {
            IndexCommentViewModel indexCommentViewModel = new IndexCommentViewModel
            {
                commentList = _commentViewConverter.Convert_To_CommentViewModel(_commentContainerLogic.GetCommentsById(Convert.ToInt32(id)))
            };
            var restaurant = new RestaurantViewModel(_restaurantContainerLogic.getRestaurantById(Convert.ToInt32(id)));

            IndexViewModel indexViewModel = new IndexViewModel();
            indexViewModel.restaurantModel = restaurant;
            indexViewModel.commentList = indexCommentViewModel.commentList;
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
                    //restaurantLogic.update((int)id, restaurantModel.convertToLogic());
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
