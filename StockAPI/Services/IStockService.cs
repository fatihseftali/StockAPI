using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Dtos;
using StockAPI.Dtos;

namespace StockAPI.Services
{
    public interface IStockService
    {
        Task<Response<List<StockDto>>> GetProductAsync(string productCode);

        Task<Response<StockDto>> CreateAsync(StockDto stock);

        Task<Response<StockDto>> GetVariantAsync(string variantCode);
    }
}
