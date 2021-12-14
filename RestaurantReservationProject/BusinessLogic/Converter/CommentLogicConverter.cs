using BusinessLogic.Models;
using DataAcces.interfaces.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Converter
{
    public class CommentLogicConverter
    {
        public CommentModel Convert_To_CommentModel(CommentDto comment)
        {
            return new CommentModel
            {
                Id = comment.Id,
                Name = comment.Name,
                Info = comment.Info,
                RestaurantId = comment.RestaurantId
            };
        }
        public List<CommentModel> Convert_To_CommentModel(List<CommentDto> comment)
        {
            return comment.Select(x => Convert_To_CommentModel(x)).ToList();
        }

        public CommentDto Convert_To_CommentDto(CommentModel commentDto)
        {
        return new CommentDto
        {
            Id = commentDto.Id,
            Name = commentDto.Name,
            Info = commentDto.Info,
            RestaurantId = commentDto.RestaurantId
            };
        }
        public List<CommentDto> Convert_To_CommentDto(List<CommentModel> comments)
        {
            return comments.Select(x => Convert_To_CommentDto(x)).ToList();
        }
    }
}
