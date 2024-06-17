using System.ComponentModel.DataAnnotations;

namespace Api.Dto.Stock;
public class CreateRequestCommentDto {
    [Required]
    [MinLength(5, ErrorMessage = "Title should be minimum 5")]
    [MaxLength(50, ErrorMessage = "Title should be maximum 50")]
    public string Title { get; set; } = string.Empty;
    [Required]
    [MinLength(5, ErrorMessage = "Content should be minimum 5")]
    [MaxLength(50, ErrorMessage = "Content should be maximum 50")]
    public string Content { get; set; } = string.Empty;
}