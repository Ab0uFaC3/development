using Api.Dto.Stock;
using Api.Models;

namespace Api.Mappers;

// static class to group extension methods
public static class CommentMapper {
    // extension method for mapping properties from Comment Entity model to CommentDto
    public static CommentDto ToCommentDto (this Comment comment) {
        return new CommentDto{
            Id = comment.Id,
            Title = comment.Title,
            Content = comment.Content,
            CreatedOn = comment.CreatedOn,
            StockId = comment.StockId
        };
    }

    public static Comment FromCommentDtoToComment (this CreateRequestCommentDto createRequestCommentDto, int stockId) {
        return new Comment {
            Title = createRequestCommentDto.Title,
            Content = createRequestCommentDto.Content,
            StockId = stockId
        };
    }
}