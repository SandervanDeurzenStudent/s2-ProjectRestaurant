﻿using DataAcces.interfaces.Dto_s;
using System;
using System.Collections.Generic;

namespace RestaurantReservationUnitTests.Mockups
{
    public class CommentDalMockup
    {
        public List<CommentDto> Comments = new List<CommentDto>();
        private CommentDalMockup cdm;


        public void RunCommentMockup()
        {
            CommentDto cmt = new CommentDto(1, "name", "info", 1);
            Comments.Add(cmt);
        }
        public CommentDto[] ReadAllComments(int commentId)
        {
            List<CommentDto> returnList = new List<CommentDto>();

            foreach (CommentDto item in Comments)
            {
                if (item.Id == commentId)
                {
                    returnList.Add(item);
                }
            }
            return returnList.ToArray();
        }

        public void UpdateComment(CommentDto comment)
        {
            foreach (CommentDto item in Comments)
            {
                if (item.Id == comment.Id)
                {
                    Comments[item.Id - 1] = comment;
                    return;
                }
            }

            throw new ArgumentException("No run with this ID was found.");
        }

        public bool CreateComment(CommentDto comment)
        {
            foreach (CommentDto item in Comments)
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
            foreach (CommentDto item in Comments)
            {
                if (item.Id == commentId)
                {
                    Comments.Remove(item);
                    return true;
                }
            }

            throw new IndexOutOfRangeException();
        }

        public CommentDto ReadComment(int runId)
        {
            foreach (CommentDto item in Comments)
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