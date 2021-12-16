using DataAcces.interfaces.dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
        public class CommentModel
        {
        
            public CommentModel()
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
    }
}
