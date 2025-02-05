﻿namespace MultiShop.Catalog.Settings
{
    public class MultiShopDatabaseSettings : IMultiShopDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CategoryCollectionName { get; set; } = null!;
        public string ProductCollectionName { get; set; } = null!;
        public string ProductImageCollectionName { get; set; } = null!;
        public string ProductDetailCollectionName { get; set; } = null!;

    }
}
