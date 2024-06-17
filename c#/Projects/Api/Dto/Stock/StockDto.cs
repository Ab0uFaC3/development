using System.ComponentModel.DataAnnotations.Schema;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Dto.Stock;
public class StockDto {
    public int Id { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public decimal Purchase { get; set; }
    public decimal LastDividend { get; set; }
    public string Industry { get; set; } = string.Empty;
    public long MarketCap { get; set; }

    public List<CommentDto>? Comment { get; set; }
}