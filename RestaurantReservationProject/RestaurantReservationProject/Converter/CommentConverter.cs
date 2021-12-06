using BusinessLogic.Models;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Converter
{
    public class CommentConverter
    {

        public CommentViewModel Convert_To_CommentViewModel(Comment restaurant)
        {
            return new CommentViewModel
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Info = restaurant.Info,
                RestaurantId = 18,
            };
        }
        public List<CommentViewModel> Convert_To_CommentViewModel(List<Comment> restaurant)
        {
            return restaurant.Select(x => Convert_To_CommentViewModel(x)).ToList();
        }

        public Comment Convert_To_Comment(CommentViewModel restaurant)
        {
            return new Comment
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Info = restaurant.Info,
                RestaurantId = 18,
            };
        }
        public List<Comment> Convert_To_Comment(List<CommentViewModel> restaurant)
        {
            return restaurant.Select(x => Convert_To_Comment(x)).ToList();
        }
    }
}
