using Microsoft.EntityFrameworkCore;
using theBakeShopApi.DBContext;
using theBakeShopApi.Entities;

namespace theBakeShopApi.Services
{
    public class ProductInfoRepository : IProductInfoRepository
    {
        private readonly ProductInfoContext _context;

        public ProductInfoRepository(ProductInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Product?> GetProductAsync(Guid productId)
        {
            return await _context.Products.Where(p => p.Id == productId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.OrderBy(p => p.ProductPrice).ToListAsync();
        }
    }
}
