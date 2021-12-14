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
        void ICommentContainerLogic.Create(CommentModel comment, int restaurantId)
        {
            _commentContainerDal.Create(_commentLogicConverter.Convert_To_CommentDto(comment), comment.Id);
        }
        void ICommentContainerLogic.Delete(int id)
        {
            _commentContainerDal.Delete(id);
        }
        List<CommentModel> ICommentContainerLogic.GetList()
        {
            List<CommentModel> comments = _commentLogicConverter.Convert_To_CommentModel(_commentContainerDal.GetList());
            return comments;
        }
        List<CommentModel> ICommentContainerLogic.GetCommentsById(int id)
        {
            List<CommentModel> comments = commentConverter.Convert_To_CommentModel(_commentContainerDal.GetCommentsById(id));
            return comments;
        }
    }
}
