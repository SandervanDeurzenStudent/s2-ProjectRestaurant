using DataAcces.interfaces.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
        public class Comment
        {
        
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

        public Comment(CommentDto dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            Info = dto.Info;
            RestaurantId = dto.RestaurantId;
        }
    }
}
