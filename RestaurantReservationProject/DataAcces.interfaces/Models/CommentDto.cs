using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.interfaces.models
{

    public class CommentDto
    {
        public CommentDto()
        {
        }

        public CommentDto(int id, string name, string info, int restaurantId)
        {
            Id = id;
            Name = name;
            Info = info;
            RestaurantId = restaurantId;
        }

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
    }

}
