using DataAcces.interfaces.models;
using System;
using System.Collections.Generic;

namespace RestaurantReservationUnitTests.Mockups
{
    public class CommentDalMockup
    {
        public List<CommentDalModel> Comments = new List<CommentDalModel>();
        private CommentDalMockup cdm;


        public void RunCommentMockup()
        {
            CommentDalModel cmt = new CommentDalModel(1, "name", "info", 1);
            Comments.Add(cmt);
        }
        public CommentDalModel[] ReadAllComments(int commentId)
        {
            List<CommentDalModel> returnList = new List<CommentDalModel>();

            foreach (CommentDalModel item in Comments)
            {
                if (item.Id == commentId)
                {
                    returnList.Add(item);
                }
            }
            return returnList.ToArray();
        }

        public void UpdateComment(CommentDalModel comment)
        {
            foreach (CommentDalModel item in Comments)
            {
                if (item.Id == comment.Id)
                {
                    Comments[item.Id - 1] = comment;
                    return;
                }
            }

            throw new ArgumentException("No run with this ID was found.");
        }

        public bool CreateComment(CommentDalModel comment)
        {
            foreach (CommentDalModel item in Comments)
            {
                if (item.Id == comment.Id)
                {
                    
                    throw new ArgumentException("A Comment with this ID already exists.");
                }
            }
            return true;
            Comments.Add(comment);
        }

        public bool DeleteComment(int commentId)
        {
            foreach (CommentDalModel item in Comments)
            {
                if (item.Id == commentId)
                {
                    Comments.Remove(item);
                    return true;
                }
            }

            throw new IndexOutOfRangeException();
        }

        public CommentDalModel ReadComment(int runId)
        {
            foreach (CommentDalModel item in Comments)
            {
                if (item.Id == runId)
                {
                    return item;
                }
            }

            return null;
        }

     
    }
}
