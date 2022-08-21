using AutoMapper;
using MongoDB.Driver;
using Shared.Dtos;
using StockAPI.Dtos;
using StockAPI.Models;
using StockAPI.Settings;
using StockAPI.Validators;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockAPI.Services
{
    public class StockService : IStockService
    {
        private readonly IMongoCollection<Stock> _stockCollection;

        private readonly IMapper _mapper;

        public StockService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);

            var database = client.GetDatabase(databaseSettings.DatabaseName);

            _stockCollection = database.GetCollection<Stock>(databaseSettings.StockCollectionName);
            _mapper = mapper;
        }

        public async Task<Response<StockDto>> CreateAsync(StockDto stockDto)
        {
            var response = new Response<StockDto>();
            var modelValidator = new StockDtoValidator();
            var modelResponse = await modelValidator.ValidateAsync(stockDto);

            if (!modelResponse.IsValid)
            {
                response.IsSuccessful = false;
                var errorMessages = new StringBuilder();
                modelResponse.Errors.ForEach(x => errorMessages.AppendLine(x.ErrorMessage));
                response.Message = errorMessages.ToString();
                return response;
            }

            var stock = _mapper.Map<Stock>(stockDto);
            await _stockCollection.InsertOneAsync(stock);

            return Response<StockDto>.Success(_mapper.Map<StockDto>(stock), 200, "İşlem başarıyla tamamlandı.");
        }

        public async Task<Response<List<StockDto>>> GetProductAsync(string productCode)
        {
            var stocks = await _stockCollection.Find<Stock>(x => x.ProductCode == productCode).ToListAsync();

            return Response<List<StockDto>>.Success(_mapper.Map<List<StockDto>>(stocks), 200, "Kayıt başarı bir şekilde getirildi.");
        }


        public async Task<Response<StockDto>> GetVariantAsync(string variantCode)
        {
            var stock = await _stockCollection.Find<Stock>(x => x.VariantCode == variantCode).FirstOrDefaultAsync();

            if (stock == null)
            {
                return Response<StockDto>.Fail("Stok bulunamadı.", 404);
            }

            return Response<StockDto>.Success(_mapper.Map<StockDto>(stock), 200,"Kayıt başarı bir şekilde getirildi.");
        }
    }
}
