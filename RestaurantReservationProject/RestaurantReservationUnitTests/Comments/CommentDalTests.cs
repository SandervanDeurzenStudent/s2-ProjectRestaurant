using System;
using System.Collections.Generic;
using System.Text;
using DataAcces.interfaces.models;
using NUnit.Framework;


namespace RestaurantReservationUnitTests.Comments
{
    class CommentDalTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //commentCreateTest
        [Test]
        public void Should_createComment()
        {
            //Arrange
            var f = new Mockups.CommentDalMockup();
            f.RunCommentMockup();
            //act
             var result = f.CreateComment(new CommentDto(23, "newname", "thisisinfo", 3));
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_createComment_WithdifferentNumbers()
        {
            //Arrange
            var f = new Mockups.CommentDalMockup();
            f.RunCommentMockup();
            //act
            var result = f.CreateComment(new CommentDto(1314, "newname", "thisisinfo", 11241));
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_ThrowException_WhenIdAlreadyExists()
        {
            //Arrange
            var f = new Mockups.CommentDalMockup();
            f.RunCommentMockup();
            //act

            //Assert
            Assert.Throws<ArgumentException>(() => f.CreateComment(new CommentDto(1, "newname", "thisisinfo", 3)));

        }

        //DeleteComment

        [Test]
        public void Should_DeleteComment()
        {
            //Arrange
            var f = new Mockups.CommentDalMockup();
            f.RunCommentMockup();
            //act
            var result = f.DeleteComment(1);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_ThrowIndexOutOfRangeException()
        {
            //Arrange
            var f = new Mockups.CommentDalMockup();
            f.RunCommentMockup();
            //act
            //Assert
            IndexOutOfRangeException e = new IndexOutOfRangeException();
           
            Assert.Throws<IndexOutOfRangeException>(() => f.DeleteComment(2));
        }

    }
}
