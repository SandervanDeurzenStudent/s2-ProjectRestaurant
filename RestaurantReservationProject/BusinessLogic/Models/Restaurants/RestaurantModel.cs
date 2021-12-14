using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
        public class RestaurantModel 
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Info { get; set; }
            public string Address { get; set; }
            public int Telephone{ get; set; }
            public string Email { get; set; }
        public RestaurantModel()
        {

        }
    }
}

