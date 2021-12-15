using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic;
using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using DataAccess.Repositories;
using NUnit.Framework;

namespace RestaurantReservationUnitTests.Restaurants
{
    class RestaurantRepositoryTests
    {
          

        //CREATE
        [Test]
        public void Should_createRestaurant()
        {
            //Arrange
            //var g = new RestaurantContainer(IRestaurantContainerContext , RestaurantLogicConverter );
            var f = new RestaurantMemoryContext();
            
            //act
            f.create(new RestaurantDto(1, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.AreEqual(f.restaurantList.Count,  2);
            
        }

        [Test]
        public void Create_Restaurant_Should_createRestaurant_DifferentId()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            f.create(new RestaurantDto(12345, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.AreEqual(f.restaurantList.Count, 2);
        }

        [Test]
        public void Create_Restaurant_Should_GiveExeption()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.create(new RestaurantDto(-5, "restaurantName", "Info", "1111 AA", 32432, "frfjr"))); 
        }



        //GETRESTAURANTBYID
        [Test]
        public void getRestaurantByid_Should_return_Restaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            var result = f.getRestaurantById(1);
            //Assert
            var newRestaurantDto = ( 1, "restaurantName", "Info", "1111 AA", 32432, "frfjr");
            Assert.AreEqual(result.Id, newRestaurantDto.Item1);
        }

        [Test]
        public void getRestaurantById_Should_return_IdNotFoundExeption()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.getRestaurantById(2));
        }



        //DELETE
        [Test]
        public void deleteRestaurant_Should_deleteRestaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
             f.Delete(1);
            //Assert
            Assert.AreEqual(f.restaurantList.Count, 0);
        }

        [Test]
        public void deleteRestaurant_Should_giveException_IdNotFound()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.Delete(234565));
        }



        //Update
        [Test]
        public void updateRestaurant_Should_updateRestaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            f.update(1, new RestaurantDto(1, "NewRestaurantName", "Info", "1111 AA", 32432, "fddrfjr"));
            //Assert
            Assert.AreEqual(f.restaurantList[0].Name, "NewRestaurantName");
        }

        [Test]
        public void updateRestaurant_Should_giveException_IdNotFound()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.update(234565, new RestaurantDto(3456, "NewrestaurantName", "Info", "1111 AA", 32432, "fddrfjr")));
        }

    }
}
