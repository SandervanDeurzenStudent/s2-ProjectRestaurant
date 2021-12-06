using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Factories;
using BusinessLogic.Interfaces.Comments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class CommentViewController : Controller
    {
        private readonly Test _context;
        ICommentContainerLogic commentContainerLogic;

        public CommentViewController()
        {
        }
      
        public async Task<IActionResult> Index()
        {
            List<CommentModel> comment = new List<CommentModel>();
            commentContainerLogic.GetList().ForEach(dto => comment.Add(new CommentModel(dto)));
            return View(comment);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentModel = await _context.CommentModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commentModel == null)
            {
                return NotFound();
            }

            return View(commentModel);
        }

        public IActionResult Create(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Info,Restaurant_id")] CommentModel commentModel, int? RestaurantId)
        {
            if (ModelState.IsValid)
            {
                commentContainerLogic.Create(commentModel.convertToLogic(), Convert.ToInt32(commentModel.Id));
                return RedirectToAction(nameof(Index));
            }
            return View(commentModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentModel = await _context.CommentModel.FindAsync(id);
            if (commentModel == null)
            {
                return NotFound();
            }
            return View(commentModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] CommentModel commentModel)
        {
            if (id != commentModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentModelExists(commentModel.Id))
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
            return View(commentModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            commentContainerLogic.Delete(Convert.ToInt32(id));
             return Redirect("/");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commentModel = await _context.CommentModel.FindAsync(id);
            _context.CommentModel.Remove(commentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentModelExists(int id)
        {
            return _context.CommentModel.Any(e => e.Id == id);
        }
    }
}
