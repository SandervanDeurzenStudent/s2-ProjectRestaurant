using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.interfaces.RestaurantsDto;
using DataAccess.Repositories;
using NUnit.Framework;

namespace RestaurantReservationUnitTests.Restaurants
{
    class RestaurantRepositoryTests
    {

        //create
        [Test]
        public void Should_createRestaurant()
        {
            //Arrange
           // var f = new RestaurantMemoryContext();
            //act
               // f.create(new RestaurantDto(1, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            //Assert.AreSame();
        }

        [Test]
        public void Create_Restaurant_Should_createRestaurant_DifferentId()
        {
            //Arrange
          //  var f = new RestaurantMemoryContext(); 
            //act
            //var result = f.create(new DataAccess.interfaces.RestaurantsDto.RestaurantDto(124223, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            //Assert.IsTrue(result);
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

        //getrestaurantById
        [Test]
        public void Should_return_Restaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            var result = f.getRestaurantById(1);
            //Assert
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_return_Exeption_alreadyExists()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.getRestaurantById(2));
        }
    }
}
