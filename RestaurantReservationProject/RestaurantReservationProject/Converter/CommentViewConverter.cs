using BusinessLogic.Models;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Converter
{
    public class CommentViewConverter
    {

        public CommentViewModel Convert_To_CommentViewModel(CommentModel comment)
        {
            return new CommentViewModel
            {
                Id = comment.Id,
                Name = comment.Name,
                Info = comment.Info,
                RestaurantId = comment.RestaurantId,
            };
        }
        public List<CommentViewModel> Convert_To_CommentViewModel(List<CommentModel> restaurant)
        {
            return restaurant.Select(x => Convert_To_CommentViewModel(x)).ToList();
        }   

        public CommentModel Convert_To_CommentModel(CommentViewModel comment)
        {
            return new CommentModel
            {
                Id = comment.Id,
                Name = comment.Name,
                Info = comment.Info,
                RestaurantId = comment.Id,
            };
        }
        public List<CommentModel> Convert_To_CommentModel(List<CommentViewModel> restaurant, int restaurantId)
        {
            return restaurant.Select(x => Convert_To_CommentModel(x)).ToList();
        }
    }
}
