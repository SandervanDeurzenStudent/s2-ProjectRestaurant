using Repositories.interfaces.dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.interfaces.interfaces
{
   public interface ICommentMySqlContext
    {
        void Create(CommentRepositoryDto comment, int commentId);
        void Delete(int id);
        List<CommentRepositoryDto> GetList();
        List<CommentRepositoryDto> GetCommentsById(int id);
    }
}
