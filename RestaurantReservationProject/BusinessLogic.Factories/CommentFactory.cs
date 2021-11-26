using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Controller.Comments;
using BusinessLogic.Interfaces.Comments;

namespace BusinessLogic.Factories
{
    public class CommentFactory
    {
        public static ICommentContainerLogic CreateCommentCollection()
        {
            return new CommentCollectionController();
        }
    }
}
