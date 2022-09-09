using theBakeShopApi.Entities;

namespace theBakeShopApi.Services
{
    public interface IProductInfoRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product?> GetProductAsync(Guid productId);
    }
}
