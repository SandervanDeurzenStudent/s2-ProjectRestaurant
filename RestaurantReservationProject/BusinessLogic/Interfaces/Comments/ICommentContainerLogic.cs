using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.Interfaces.Comments
{
    public interface ICommentContainerLogic
    {
        void Create(CommentModel restaurant, int restaurantId);
        void Delete(int id);
        List<CommentModel> GetList();
        List<CommentModel> GetCommentsById(int id);
    }
}
