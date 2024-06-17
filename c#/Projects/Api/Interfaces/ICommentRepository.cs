using Api.Dto.Stock;
using Api.Models;

namespace Api.Interfaces;

public interface ICommentRepository
{
    Task<bool> CheckForStock (int id);
    Task<List<CommentDto>> GetAllComments ();
    Task<Comment?> GetCommentById (int id);
    Task<Comment?> CreateComment (Comment createRequestComment);
    Task<Comment?> UpdateComment (int id, CreateRequestCommentDto updateRequestComment);
}