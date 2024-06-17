using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

[Table("tbl_comment")]
public class Comment {
    [Column("id")]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; } = string.Empty;
    [Column("content")]
    public string Content { get; set; } = string.Empty;
    [Column("created_on")]
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    [Column("stock_id")]
    public int StockId { get; set; }
    // Navigation property - allows us to navigate to another model
    public Stock? Stock { get; set; }
    
}