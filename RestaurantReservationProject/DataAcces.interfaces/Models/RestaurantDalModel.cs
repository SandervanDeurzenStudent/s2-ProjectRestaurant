using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.interfaces.RestaurantsDto
{
    public class RestaurantDalModel
    {
        public RestaurantDalModel()
        {
        }

        public RestaurantDalModel(int id, string name, string info, string address, int telephone, string email)
        {
            Id = id;
            Name = name;
            Info = info;
            Address = address;
            Telephone = telephone;
            Email = email;
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
        public string Address
        {
            get;
            set;
        }
        public int Telephone
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public RestaurantDalModel convertToDto()
        {
            return new RestaurantDalModel(Id, Name, Info, Address, Telephone, Email);
        }
    }
}


