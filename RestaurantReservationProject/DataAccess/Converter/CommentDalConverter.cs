using DataAcces.interfaces.models;
using Repositories.interfaces.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Converter
{
    public class CommentDalConverter
    {
        public CommentDalModel Convert_To_CommentDalModel (CommentRepositoryDto comment)
        {
            return new CommentDalModel
            {
                Id = comment.Id,
                Name = comment.Name,
                Info = comment.Info,
                RestaurantId = comment.Restaurantid
            };
        }
        public List<CommentDalModel> Convert_To_CommentDalModel(List<CommentRepositoryDto> comment)
        {
            return comment.Select(x => Convert_To_CommentDalModel(x)).ToList();
        }

        public CommentRepositoryDto Convert_To_CommentRepositoryDto(CommentDalModel commentDto)
        {
            return new CommentRepositoryDto
            {
                Id = commentDto.Id,
                Name = commentDto.Name,
                Info = commentDto.Info,
                Restaurantid = commentDto.RestaurantId
            };
        }
        public List<CommentRepositoryDto> Convert_To_CommentRepositoryDto(List<CommentDalModel> comments)
        {
            return comments.Select(x => Convert_To_CommentRepositoryDto(x)).ToList();
        }
    }
}
