using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.Interfaces.Comments
{
    public interface ICommentContainerLogic
    {
        void Create(Comment restaurant, int restaurantId);
        void Delete(int id);
        List<Comment> GetList();
        List<Comment> GetCommentsById(int id);
    }
}
