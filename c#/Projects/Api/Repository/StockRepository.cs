using Api.Data;
using Api.Dto.Stock;
using Api.Interfaces;
using Api.Mappers;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository;

public class StockRepository: IStockRepository
{
    private readonly ApplicationDbContext _context;
    public StockRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Stock> CreateStock(Stock stock)
    {
        await _context.Stocks.AddAsync(stock);
        await _context.SaveChangesAsync();
        return stock;
    }

    public async Task<List<StockDto>> GetAllStocks () {
        return await _context.Stocks.Include(b => b.Comments).Select(a => a.ToStockDto()).ToListAsync();
    }

    public async Task<Stock?> GetById(int id)
    {
        return await _context.Stocks.Include(b => b.Comments).FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<Stock?> UpdateStock(int id, CreateRequestStockDto updateRequestStockDto)
    {
        var stockModel = await _context.Stocks.FirstOrDefaultAsync(a => a.Id == id);
        if(stockModel == null) {
            return null;
        }

        stockModel.Symbol = updateRequestStockDto.Symbol;
        stockModel.CompanyName = updateRequestStockDto.CompanyName;
        stockModel.Purchase = updateRequestStockDto.Purchase;
        stockModel.LastDividend = updateRequestStockDto.LastDividend;
        stockModel.Industry = updateRequestStockDto.Industry;
        stockModel.MarketCap = updateRequestStockDto.MarketCap;
        
       await _context.SaveChangesAsync();
       return stockModel;
    }
}