using System;
using BusinessLogic.Models;

namespace Presentation.Models
{
    public class CommentViewModel
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Info
        {
            get;
            set;
        }
        public int RestaurantId
        {
            get;
            set;
        }

        public CommentViewModel()
        {
        }

        public CommentViewModel(CommentModel comment)
        {
            Id = comment.Id;
            Name = comment.Name;
            Info = comment.Info;
            RestaurantId = RestaurantId;

        }
    }
}

