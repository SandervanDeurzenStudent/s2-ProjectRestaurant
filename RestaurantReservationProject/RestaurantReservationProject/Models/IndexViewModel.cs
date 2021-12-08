using Presentation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class IndexViewModel
    {
        public RestaurantViewModel restaurantModel { get; set; }
        public List<CommentViewModel> commentList { get; set; }
    }
}
