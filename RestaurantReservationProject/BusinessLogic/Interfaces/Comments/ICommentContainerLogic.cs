using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.Interfaces.Comments
{
    public interface ICommentContainerLogic
    {
        void Create(CommentModel comment);
        void Delete(int id);
        List<CommentModel> GetList();
        List<CommentModel> GetCommentsById(int id);
    }
}
