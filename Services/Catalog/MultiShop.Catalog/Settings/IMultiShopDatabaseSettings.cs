namespace MultiShop.Catalog.Settings
{
    public interface IMultiShopDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string ProductImageCollectionName { get; set; }
        public string ProductDetailCollectionName { get; set; }
    }
}
