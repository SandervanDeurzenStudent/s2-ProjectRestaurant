using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Factories;
using DataAcces.interfaces.interfaces;

namespace BusinessLogic.Controller.Comments
{
    public class CommentCollection : ICommentContainerLogic
    {
        ICommentContainerDal commentContainerDal;
        public CommentCollection()
        {
            commentContainerDal = CommentFactoryDal.CreateCommentCollection();
        }
        void ICommentContainerLogic.Create(Comment comment, int restaurantId)
        {
            commentContainerDal.Create(comment.convertToDto(), comment.Id);
        }
        void ICommentContainerLogic.Delete(int id)
        {
            commentContainerDal.Delete(id);
        }
        List<Comment> ICommentContainerLogic.GetList()
        {
            List<Comment> comments = new List<Comment>();
            commentContainerDal.GetList().ForEach(dto => comments.Add(new Comment(dto)));
            return comments;
        }
        List<Comment> ICommentContainerLogic.GetCommentsById(int id)
        {
            List<Comment> comments = new List<Comment>();
            commentContainerDal.GetCommentsById(id).ForEach(dto => comments.Add(new Comment(dto)));
            return comments;
        }
    }
}
