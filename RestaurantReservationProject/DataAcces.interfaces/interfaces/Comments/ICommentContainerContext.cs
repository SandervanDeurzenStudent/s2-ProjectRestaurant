using DataAcces.interfaces.dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.interfaces.interfaces
{
    public interface ICommentContainerContext
    {
        void Create(CommentDto comment);
        void Delete(int id);
        List<CommentDto> GetList();
        List<CommentDto> GetCommentsById(int id);
      
    }
}
