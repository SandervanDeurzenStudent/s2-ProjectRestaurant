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

        public CommentViewModel(int id, string name, string info, int restaurantId)
        {
            Id = id;
            Name = name;
            Info = info;
            RestaurantId = restaurantId;
        }

        public CommentViewModel(string name, string info, int restaurantId)
        {
            Name = name;
            Info = info;
            RestaurantId = restaurantId;
        }
        public Comment convertToLogic()
        {
            return new Comment(Id, Name, Info, RestaurantId);
        }
        public CommentViewModel(Comment comment)
        {
            Id = comment.Id;
            Name = comment.Name;
            Info = comment.Info;
            RestaurantId = RestaurantId;

        }
    }
}

