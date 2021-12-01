using System;
using System.Collections.Generic;
using System.Text;
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
            var f = new Repositories.memory.RestaurantMemoryContext();
            //act
            var result = f.create(new DataAccess.interfaces.RestaurantsDto.RestaurantDto(1, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_createRestaurant_DifferentId()
        {
            //Arrange
            var f = new Repositories.memory.RestaurantMemoryContext();
            //act
            var result = f.create(new DataAccess.interfaces.RestaurantsDto.RestaurantDto(124223, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_GiveExeption()
        {
            //Arrange
            var f = new Repositories.memory.RestaurantMemoryContext();
            //act
            var result = f.create(new DataAccess.interfaces.RestaurantsDto.RestaurantDto(-0, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.AreSame(new ArgumentException(), result);
        }
        public void Should_Give()
        {
            //Arrange
            var f = new Repositories.memory.RestaurantMemoryContext();
            //act
            var result = f.create(new DataAccess.interfaces.RestaurantsDto.RestaurantDto(-0, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.AreSame(new ArgumentException(), result);
        }
    }
}
