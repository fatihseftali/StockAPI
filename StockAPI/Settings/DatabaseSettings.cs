﻿namespace StockAPI.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string StockCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
