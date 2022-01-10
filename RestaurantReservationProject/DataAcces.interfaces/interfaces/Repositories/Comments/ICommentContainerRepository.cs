using DataAcces.interfaces.dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.interfaces.interfaces.Repositories.Comments
{
    public interface ICommentContainerRepository
    {
        void Create(CommentDto comment);
        void Delete(int id);
        List<CommentDto> GetList();
        List<CommentDto> GetCommentsById(int id);

    }
}
