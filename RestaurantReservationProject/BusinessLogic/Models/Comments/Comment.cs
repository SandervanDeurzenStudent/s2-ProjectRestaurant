using DataAcces.interfaces.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
        public class Comment
        {
        private CommentDalModel dto;
        
        public Comment()
        {

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

        public Comment(int id, string name, string info, int restaurantId)
        {
            Id = id;
            Name = name;
            Info = info;
            RestaurantId = restaurantId;
        }

        public Comment(string name, string info, int restaurantId)
        {
            Name = name;
            Info = info;
            RestaurantId = restaurantId;
                
        }

        public Comment(CommentDalModel dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            Info = dto.Info;
            RestaurantId = dto.RestaurantId;
        }

       
        public CommentDalModel convertToDto()
        {
            return new CommentDalModel(Id, Name, Info, RestaurantId);
        }
    }
}
