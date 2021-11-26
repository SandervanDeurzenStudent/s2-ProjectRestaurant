using DataAcces.interfaces.Dto_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.interfaces.interfaces
{
    public interface ICommentContainerDal
    {
        void Create(CommentDto restaurant, int RestaurantId);
        void Delete(int id);
        List<CommentDto> GetList();
        List<CommentDto> GetCommentsById(int id);
      
    }
}
