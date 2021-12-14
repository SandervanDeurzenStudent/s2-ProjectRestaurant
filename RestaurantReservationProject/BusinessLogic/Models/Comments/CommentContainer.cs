using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataAcces.interfaces.interfaces;
using BusinessLogic.Converter;

namespace BusinessLogic.Controller.Comments
{
    public class CommentContainer : ICommentContainerLogic
    {
        ICommentContainerDal _commentContainerDal;
        CommentLogicConverter _commentLogicConverter;
        private CommentLogicConverter commentConverter = new CommentLogicConverter();
        public CommentContainer(ICommentContainerDal commentContainerDal, CommentLogicConverter commentLogicConverter)
        {
            _commentContainerDal = commentContainerDal;
            _commentLogicConverter = commentLogicConverter;
        }
        void ICommentContainerLogic.Create(Comment comment, int restaurantId)
        {
            _commentContainerDal.Create(_commentLogicConverter.Convert_To_CommentDto(comment), comment.Id);
        }
        void ICommentContainerLogic.Delete(int id)
        {
            _commentContainerDal.Delete(id);
        }
        List<Comment> ICommentContainerLogic.GetList()
        {
            List<Comment> comments = new List<Comment>();
            _commentContainerDal.GetList().ForEach(dto => comments.Add(new Comment(dto)));
            return comments;
        }
        List<Comment> ICommentContainerLogic.GetCommentsById(int id)
        {
            List<Comment> comments = commentConverter.Convert_To_Comment(_commentContainerDal.GetCommentsById(id));
            //commentContainerDal.GetCommentsById(id).ForEach(dto => comments.Add(new Comment(dto)));
            return comments;
        }
    }
}
