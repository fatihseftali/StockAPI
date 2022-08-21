using AutoMapper;
using StockAPI.Dtos;
using StockAPI.Models;

namespace StockAPI.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {          
            CreateMap<Stock, StockDto>().ReverseMap();      
        }
    }
}
