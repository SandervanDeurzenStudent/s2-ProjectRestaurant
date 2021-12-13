using BusinessLogic.Models;
using DataAcces.interfaces.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Converter
{
    class CommentLogicConverter
    {
        public Comment Convert_To_Comment(CommentDalModel comment)
        {
            return new Comment
            {
                Id = comment.Id,
                Name = comment.Name,
                Info = comment.Info,
                RestaurantId = comment.RestaurantId
            };
        }
        public List<Comment> Convert_To_Comment(List<CommentDalModel> comment)
        {
            return comment.Select(x => Convert_To_Comment(x)).ToList();
        }

        public CommentDalModel Convert_To_CommentDto(Comment commentDto)
        {
        return new CommentDalModel
        {
            Id = commentDto.Id,
            Name = commentDto.Name,
            Info = commentDto.Info,
            RestaurantId = commentDto.RestaurantId
            };
        }
        public List<CommentDalModel> Convert_To_CommentDto(List<Comment> comments)
        {
            return comments.Select(x => Convert_To_CommentDto(x)).ToList();
        }
    }
}
