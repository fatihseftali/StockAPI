using System;

namespace StockAPI.Dtos
{
    public class StockDto
    {
        public string Id { get; set; }

        public string VariantCode { get; set; }

        public string ProductCode { get; set; }

        public int Quantity { get; set; }

        public bool IsActiveted { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
