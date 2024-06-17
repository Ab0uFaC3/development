using Api.Data;
using Api.Dto.Stock;
using Api.Interfaces;
using Api.Mappers;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository;

public class CommentRepository: ICommentRepository
{
    private readonly ApplicationDbContext _context;
    public CommentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CheckForStock(int id)
    {
        return await _context.Stocks.AnyAsync(a => a.Id == id);
    }

    public async Task<Comment?> CreateComment(Comment comment)
    {
        await _context.AddAsync(comment);
        await _context.SaveChangesAsync();

        return comment;
    }

    public async Task<List<CommentDto>> GetAllComments()
    {
        return await _context.Comments.Select(a => a.ToCommentDto()).ToListAsync();
    }

    public async Task<Comment?> GetCommentById(int id)
    {
        return await _context.Comments.FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<Comment?> UpdateComment(int id, CreateRequestCommentDto updateRequestComment)
    {
        var comment = await _context.Comments.FindAsync(id);
        if(comment == null) {
            return null;
        }

        comment.Title = updateRequestComment.Title;
        comment.Content = updateRequestComment.Content;
        
       await _context.SaveChangesAsync();
       return comment;
    }
}