using DataAcces.interfaces.dtos;
using DataAccess.MemoryContext;
using DataAccess.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReservationUnitTests.Comments
{
    class CommentRepositoryTests
    {

        CommentMemoryContext _commentMemoryContext;
        CommentRepository _commentRepository;


        [SetUp]
        public void SetUp()
        {
            //memoryContext
            _commentMemoryContext = new CommentMemoryContext();
            _commentRepository = new CommentRepository(_commentMemoryContext);
        }


        //CREATE
        [Test]
        public void Should_createComment()
        {
            //Arrange
            CommentDto comment = new CommentDto(3, "commentName", "Info",8);
            //act
            _commentRepository.Create(comment);
            //Assert
            Assert.AreEqual(_commentMemoryContext.commentList.Count, 2);
        }

        [Test]
        public void Create_Restaurant_Should_createComment_DifferentId()
        {
            //Arrange
            CommentDto comment = new CommentDto(56734, "commenttName", "Info", 8);
            //act
            _commentRepository.Create(comment);
            //Assert
            Assert.AreEqual(_commentMemoryContext.commentList.Count, 2);
        }

        [Test]
        public void Create_Comment_Should_GiveExeption()
        {
            //Arrange
            CommentDto comment = new CommentDto(-5, "restaurantName", "Info",6);
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _commentMemoryContext.Create(comment));
        }

        //GETRESTAURANTBYID
        [Test]
        public void getCommentByid_Should_return_Comment()
        {
            //Arrange
            int id = 1;
            //act
            var result = _commentRepository.GetCommentsById(id);
            //Assert
            Assert.AreNotEqual(result.Count, 0);
        }

        [Test]
        public void getCommentById_Should_return_IdNotFoundExeption()
        {
            //Arrange

            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _commentRepository.GetCommentsById(14335));
        }

        //DELETE
        [Test]
        public void deleteComment_Should_deleteComment()
        {
            //Arrange
           
            //act
            _commentMemoryContext.Delete(1);
            //Assert
            Assert.AreEqual(_commentMemoryContext.commentList.Count, 0);
        }

        [Test]
        public void deleteComment_Should_giveException_IdNotFound()
        {
            //Arrange
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _commentRepository.Delete(234565));
        }

    }
}
