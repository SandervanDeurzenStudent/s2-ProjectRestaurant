using DataAcces.interfaces.dtos;
using DataAcces.interfaces.interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.MemoryContext
{
    public class CommentMemoryContext : ICommentContainerContext
    {
        public List<CommentDto> commentList = new List<CommentDto>();

        public CommentMemoryContext()
        {
            commentList.Add(new CommentDto(1, "username", "info", 2));
        }
        public void Create(CommentDto comment)
        {
            if (comment.Id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id is invalid");
            }
            else
            {
                commentList.Add(comment);
            }
        }

        public void Delete(int id)
        {
            foreach (CommentDto item in commentList)
            {
                if (item.Id == id)
                {
                    commentList.Remove(item);
                    return;
                }
            }
            throw new ArgumentOutOfRangeException("Restaurant does not exist");
        }

        public List<CommentDto> GetCommentsById(int commentId)
        {
            List<CommentDto> comments = new List<CommentDto>();
            foreach (var item in commentList)
            {
                if (commentId == item.Id)
                {
                     comments.Add(item);
                }
            }
           
            if (comments.Count != 0)
            {
                return comments;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Restaurant does not exist");
            }
        }

        public CommentDto getRestaurantWithComments( CommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public List<CommentDto> GetList()
        {
            return commentList.GetRange(0, 1);
        }

        public void update(int id, CommentDto comment)
        {
            foreach (CommentDto item in commentList)
            {
                if (item.Id == id)
                {
                    commentList[item.Id - 1] = comment;
                    return;
                }
            }
            throw new ArgumentOutOfRangeException("No run with this ID was found.");
        }
    }
}
