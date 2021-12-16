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
        ICommentContainerContext _commentContainerContext;
        CommentLogicConverter _commentLogicConverter;
        public CommentContainer(ICommentContainerContext commentContainerContext, CommentLogicConverter commentLogicConverter)
        {
            _commentContainerContext = commentContainerContext;
            _commentLogicConverter = commentLogicConverter;
        }
        void ICommentContainerLogic.Create(CommentModel comment)
        {
            _commentContainerContext.Create(_commentLogicConverter.Convert_To_CommentDto(comment));
        }
        void ICommentContainerLogic.Delete(int id)
        {
            _commentContainerContext.Delete(id);
        }
        List<CommentModel> ICommentContainerLogic.GetList()
        {
            List<CommentModel> comments = _commentLogicConverter.Convert_To_CommentModel(_commentContainerContext.GetList());
            return comments;
        }
        List<CommentModel> ICommentContainerLogic.GetCommentsById(int id)
        {
            List<CommentModel> comments = _commentLogicConverter.Convert_To_CommentModel(_commentContainerContext.GetCommentsById(id));
            return comments;
        }
    }
}
