using Api.Data;
using Api.Dto.Stock;
using Api.Interfaces;
using Api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StockController: ControllerBase {
    
    private readonly IStockRepository _stockRepository;
    public StockController(ApplicationDbContext context, IStockRepository stockRepository)
    {
        _stockRepository = stockRepository;
    }

    [HttpGet("GetAllStocks")]
    public async Task<IActionResult> GetAllStocks () {
        // abstracting the DB implementation
        var stocks = await _stockRepository.GetAllStocks();
        return Ok(stocks);
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById ([FromRoute] int id) {
        var stock = await _stockRepository.GetById(id);
        if(stock == null) {
            return NotFound();
        }
        return Ok(stock.ToStockDto());
    }

    [HttpPost("CreateStock")]
    public async Task<IActionResult> CreateStock ([FromBody] CreateRequestStockDto requestStockDto) {
        var stockModel = await _stockRepository.CreateStock(requestStockDto.FromCreateRequestStockToStock());

        // Call GetById with Id of the newly created stock data with ToStockDto() format in response
        return CreatedAtAction(nameof(GetById), new { stockModel.Id}, stockModel.ToStockDto());
        
    }

    [HttpPut("UpdateStock/{id:int}")]
    public async Task<IActionResult> CreateStock ([FromRoute] int id, [FromBody] CreateRequestStockDto updateRequestStockDto) {
        var stockModel = await _stockRepository.UpdateStock(id, updateRequestStockDto);
        if (stockModel == null) {
            return NotFound();
        }
        return Ok(stockModel.ToStockDto());
        
    }

}