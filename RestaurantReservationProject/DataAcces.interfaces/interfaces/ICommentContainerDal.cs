using DataAcces.interfaces.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.interfaces.interfaces
{
    public interface ICommentContainerDal
    {
        void Create(CommentDalModel comment, int commentId);
        void Delete(int id);
        List<CommentDalModel> GetList();
        List<CommentDalModel> GetCommentsById(int id);
      
    }
}
