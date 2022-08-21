using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAPI.Services;
using System.Threading.Tasks;
using Shared.ControllerBases;
using StockAPI.Dtos;
using System;

namespace StockAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : CustomBaseController
    {
        private readonly IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        [Route("api/[controller]/GetProduct/{productCode}/product")]
        public async Task<IActionResult> GetProduct(string productCode)
        {
            var stocks = await _stockService.GetProductAsync(productCode);

            return CreateActionResultInstance(stocks);
        }

        [HttpGet]
        [Route("api/[controller]/GetVariant/{variantCode}/variant")]
        public async Task<IActionResult> GetVariant(string variantCode)
        {
            var stock = await _stockService.GetVariantAsync(variantCode);

            return CreateActionResultInstance(stock);
        }


        [HttpPost]
        public async Task<IActionResult> Create(StockDto stockDto)
        {
            var response = await _stockService.CreateAsync(stockDto);
      
            return CreateActionResultInstance(response);
        }
    }
}
