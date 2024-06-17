using Api.Dto.Stock;
using Api.Models;

namespace Api.Mappers;

// static class to group extension methods
public static class StockMapper {
    // extension method for mapping properties from Stock Entity model to StockDto
    public static StockDto ToStockDto (this Stock stock) {
        return new StockDto{
            Id = stock.Id,
            Symbol = stock.Symbol,
            CompanyName = stock.CompanyName,
            Purchase = stock.Purchase,
            LastDividend = stock.LastDividend,
            Industry = stock.Industry,
            MarketCap = stock.MarketCap,
            Comment = stock.Comments.Select(a => a.ToCommentDto()).ToList()
        };
    }

    // maps the incoming DTO for stock creation to Stock Entity Model
    public static Stock FromCreateRequestStockToStock (this CreateRequestStockDto stock) {
        return new Stock{
            Symbol = stock.Symbol,
            CompanyName = stock.CompanyName,
            Purchase = stock.Purchase,
            LastDividend = stock.LastDividend,
            Industry = stock.Industry,
            MarketCap = stock.MarketCap
        };
    }

}