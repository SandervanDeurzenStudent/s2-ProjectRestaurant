using DataAcces.interfaces.dtos;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.interfaces.Repositories.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class CommentRepository : ICommentContainerRepository
    {
        private ICommentContainerContext _commentContainerContext;
        public CommentRepository(ICommentContainerContext commentContainerContext)
        {
            _commentContainerContext = commentContainerContext;
        }
       
        public void Create(CommentDto comment)
        {
            _commentContainerContext.Create(comment);
        }

        public void Delete(int id)
        {
            _commentContainerContext.Delete(id);
        }

        public List<CommentDto> GetList()
        {
            List<CommentDto> comments = _commentContainerContext.GetList();
            return comments;
        }

        public List<CommentDto> GetCommentsById(int id)
        {
            List<CommentDto> comments = _commentContainerContext.GetCommentsById(id);
            return comments;
        }
    }
}
