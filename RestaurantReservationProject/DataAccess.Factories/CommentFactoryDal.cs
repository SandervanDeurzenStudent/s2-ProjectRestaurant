using DataAcces.interfaces.interfaces;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Factories
{
    public class CommentFactoryDal
    {
        public static ICommentContainerDal CreateCommentCollection()
        {
            return new CommentDal();
        }
    }
}
