using System;
using BusinessLogic.Controller.Comments;
using BusinessLogic.Functions;
using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.Repositories;
using DataAccess.interfaces.RestaurantsDto;
using DataAccess.Repositories;
using DataAccess.Repository;
using NUnit.Framework;
using Presentation.Controllers;

namespace RestaurantReservationUnitTests.Restaurants
{
    public class RestaurantRepositoryTests
    {
        RestaurantMemoryContext _restaurantMemoryContext;
        RestaurantRepository _restaurantRepository;

        IRestaurantContainerRepository _restaurantContainerRepository;
        IRestaurantContainerLogic _restaurantContainerLogic;

        ICommentContainerLogic _commentContainerLogic;
        ICommentContainerContext _commentContainerContext;
        IRestaurantLogic _restaurantLogic;

        RestaurantViewController _rvc;

        [SetUp]
        public void SetUp()
        {
            // initialize here
            _restaurantContainerLogic = new RestaurantContainer(_restaurantContainerRepository);
            _commentContainerLogic = new CommentContainer(_commentContainerContext);
            _restaurantLogic = new Restaurant(_restaurantRepository);

            _rvc = new RestaurantViewController(_restaurantContainerLogic, _commentContainerLogic, _restaurantLogic);
            //memoryContext
            _restaurantMemoryContext = new RestaurantMemoryContext();
            _restaurantRepository = new RestaurantRepository(_restaurantMemoryContext, _restaurantMemoryContext);
        }

        //CREATE
        [Test]
        public void Should_createRestaurant()
        {
        //Arrange
        RestaurantDto restaurant = new RestaurantDto (3, "restaurantName", "Info", "111166 AA", 32432, "frfjr");
        //act
         _restaurantRepository.create(restaurant);
        //Assert
         Assert.AreEqual(_restaurantMemoryContext.restaurantList.Count, 2);
        }

        [Test]
        public void Create_Restaurant_Should_createRestaurant_DifferentId()
        {
            //Arrange
            RestaurantDto restaurant = new RestaurantDto(56734, "restaurantName", "Info", "111166 AA", 32432, "frfjr");
            //act
            _restaurantRepository.create(restaurant);
            //Assert
            Assert.AreEqual(_restaurantMemoryContext.restaurantList.Count, 2);
        }

        [Test]
        public void Create_Restaurant_Should_GiveExeption()
        {
            //Arrange
            RestaurantDto restaurant = new RestaurantDto(-5, "restaurantName", "Info", "1111 AA", 32432, "frfjr");
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantMemoryContext.create(restaurant)); 
        }

        //GETRESTAURANTBYID
        [Test]
        public void getRestaurantByid_Should_return_Restaurant()
        {
            //Arrange
            var newRestaurantDto = (1, "restaurantName", "Info", "1111 AA", 32432, "frfjr");
            //act
            var result = _restaurantRepository.getRestaurantById(1);
            //Assert
            Assert.AreEqual(result.Id, newRestaurantDto.Item1);
        }

        [Test]
        public void getRestaurantById_Should_return_IdNotFoundExeption()
        {
            //Arrange
            
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantRepository.getRestaurantById(14335));
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
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantRepository.Delete(234565));
        }

        //Update
        [Test]
        public void updateRestaurant_Should_updateRestaurant()
        {
            //Arrange
            RestaurantDto restaurant = new RestaurantDto(1, "NewRestaurantName", "Info", "1111 AA", 32432, "fddrfjr");
            //act
            _restaurantRepository.update(1, restaurant);
            //Assert
            Assert.AreEqual(_restaurantMemoryContext.restaurantList[0].Name, "NewRestaurantName");
        }

        [Test]
        public void updateRestaurant_Should_giveException_IdNotFound()
        {
            //Arrange
            RestaurantDto restaurant = new RestaurantDto(3456, "NewrestaurantName", "Info", "1111 AA", 32432, "fddrfjr");
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantRepository.update(234565, restaurant));
        }

        [Test]
        public void getRestaurantByid_Should_return_Restaurant()
        {
            //Arrange

            //var k = new RestaurantViewModel()
            //{
            //    Id = 1,
            //    Name = "fr",
            //    Info = "rf",
            //    Address = "vbvb",
            //    Telephone = 34342,
            //    Email = "blabla@email.com"
            //};
            //_rvc.Edit(2);
            ////act
            //var result = _restaurantRepository.getRestaurantById(1);
            ////Assert
            //Assert.AreEqual(result.Id, newRestaurantDto.Item1);
        }
    }
}
