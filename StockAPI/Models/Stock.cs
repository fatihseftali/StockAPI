using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace StockAPI.Models
{
    public class Stock
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string VariantCode { get; set; }

        public string ProductCode { get; set; }

        public int Quantity { get; set; }

        public bool IsActiveted { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }
    }
}
