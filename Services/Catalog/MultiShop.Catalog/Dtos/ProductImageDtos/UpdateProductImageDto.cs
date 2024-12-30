namespace MultiShop.Catalog.Dtos.ProductImageDtos
{
    public class UpdateProductImageDto
    {
        public string ProductImageID { get; set; }
        public List<string> Images { get; set; }
        public string ProductId { get; set; }
    }
}
