using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Api.Models;

[Table("tbl_stock")]
public class Stock {
    [Column("id")]
    public int Id { get; set; }
    [Column("symbol")]
    public string Symbol { get; set; } = string.Empty;
    [Column("company_name")]
    public string CompanyName { get; set; } = string.Empty;

    [Column("purchase", TypeName = "decimal(18, 2)")]
    public decimal Purchase { get; set; }
    
    [Column("last_dividend",  TypeName = "decimal(18, 2)")]
    public decimal LastDividend { get; set; }
    [Column("industry")]
    public string Industry { get; set; } = string.Empty;
    [Column("market_cap")]
    public long MarketCap { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
}