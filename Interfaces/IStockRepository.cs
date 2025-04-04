using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllStocksAsync(QueryObject query);
        Task<Stock?> GetStockByIdAsync(int? id);
        Task<Stock?> GetStockBySymbolAsync(string symbol);
        Task<Stock?> CreateStockRequest(CreateStockDto createStockDto);
        Task<Stock?> UpdateStockRequest(int? id, UpdateDto updateStockDto);
        Task<Stock?> RemoveStock(int? id);

        Task<bool> StockExists(int? id);
    }
}