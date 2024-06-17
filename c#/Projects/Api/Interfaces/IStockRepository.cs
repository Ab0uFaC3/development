using Api.Dto.Stock;
using Api.Models;

namespace Api.Interfaces;

public interface IStockRepository
{
    Task<List<StockDto>> GetAllStocks ();
    Task<Stock?> GetById (int id);
    Task<Stock> CreateStock (Stock stock);
    Task<Stock?> UpdateStock(int id, CreateRequestStockDto stock);
}