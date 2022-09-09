namespace theBakeShopApi.Models
{
    public class ProductDto
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string? ProductDescription { get; set; }

        public int ProductPrice { get; set; } = 0;

        public string ImageUrl { get; set; } = string.Empty;


    }
}
