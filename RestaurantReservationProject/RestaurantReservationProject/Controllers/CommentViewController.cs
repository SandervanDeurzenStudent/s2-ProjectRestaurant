using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Restraurants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Presentation.Converter;
using Presentation.models;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class CommentViewController : Controller
    {
        ICommentContainerLogic _commentContainerLogic;
        CommentViewConverter _commentViewConverter;
        IRestaurantContainerLogic _restaurantContainerLogic;
        public CommentViewController(ICommentContainerLogic commentContainerLogic, CommentViewConverter commentViewConverter, IRestaurantContainerLogic restaurantContainerLogic)
        {
            _commentViewConverter = commentViewConverter;
            _commentContainerLogic = commentContainerLogic;
            _restaurantContainerLogic = restaurantContainerLogic;
        }
        public IActionResult Index()
        {
            List<CommentViewModel> comment = new List<CommentViewModel>();
            _commentContainerLogic.GetList().ForEach(dto => comment.Add(new CommentViewModel(dto)));
            return View(comment);
        }

        public IActionResult Create(int? id)
        {
            var restaurant = new RestaurantViewModel(_restaurantContainerLogic.getRestaurantById(Convert.ToInt32(id)));
            return View(restaurant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Id,Name,Info,Restaurant_id")] CommentViewModel commentModel)
        {
            if (ModelState.IsValid)
            {
                _commentContainerLogic.Create(_commentViewConverter.Convert_To_CommentModel(commentModel));
                return RedirectToAction(nameof(Index));
            }
            return View(commentModel);
        }

        public IActionResult Delete(int? id)
        {
            _commentContainerLogic.Delete(Convert.ToInt32(id));
             return Redirect("/");
        }

        [HttpPost, ActionName("Delete")]
        public  IActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
