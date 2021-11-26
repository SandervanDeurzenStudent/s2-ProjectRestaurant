using DataAcces.interfaces.Dto_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
        public class Comment
        {
        private CommentDto dto;

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

        public Comment(CommentDto dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            Info = dto.Info;
            RestaurantId = dto.Restaurantid;
        }

        //public Restaurant(RestaurantDto restaurantDto)
        //{
        //    Id = restaurantDto.Id;
        //    Name = restaurantDto.Name;
        //    Info = restaurantDto.Info;
        //    Address = restaurantDto.Address;
        //    Telephone = restaurantDto.Telephone;
        //    Email = restaurantDto.Email;
        //}
        //public RestaurantDto convertToDto()
        //{
        //    return new RestaurantDto(Id, Name, Info, Address, Telephone, Email);
        //}
        public CommentDto convertToDto()
        {
            return new CommentDto(Id, Name, Info, RestaurantId);
        }
    }
}
