using Api.Dto.Stock;
using Api.Interfaces;
using Api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController: ControllerBase {
    private readonly ICommentRepository _commentRepository;
    public CommentController(ICommentRepository commentkRepository)
    {
        _commentRepository = commentkRepository;
    }

    [HttpGet("GetAllComments")]
    public async Task<IActionResult> GetAllComments () {
        // abstracting the DB implementation
        var comments = await _commentRepository.GetAllComments();
        return Ok(comments);
    }

    [HttpGet("GetCommentById/{id:int}")]
    public async Task<IActionResult> GetCommentById ([FromRoute] int id) {
        var commentById = await _commentRepository.GetCommentById(id);
        if (commentById == null) {
            return NotFound();
        }

        return Ok (commentById.ToCommentDto()); 
    }

    [HttpPost("CreateComment/{stockId:int}")]
    public async Task<IActionResult> CreateComment ([FromRoute] int stockId, [FromBody] CreateRequestCommentDto createRequestComment) {
        if (!ModelState.IsValid) {
            return BadRequest (ModelState);
        }

        // If stock not present, throw error
        if (! await _commentRepository.CheckForStock(stockId)) {
            return BadRequest("Stock not present");
        }

        var comment = await _commentRepository.CreateComment(createRequestComment.FromCommentDtoToComment(stockId));
        if (comment == null) {
            return NotFound();
        }

        return CreatedAtAction(nameof(GetCommentById), new {comment.Id}, comment.ToCommentDto());

    }

    [HttpPost("UpdateComment/{id:int}")]
    public async Task<IActionResult> UpdateComment ([FromRoute] int id, [FromBody] CreateRequestCommentDto updateRequestComment) {

        var comment = await _commentRepository.UpdateComment(id, updateRequestComment);
        if (comment == null) {
            return NotFound();
        }

        return Ok (comment.ToCommentDto());

    }
}