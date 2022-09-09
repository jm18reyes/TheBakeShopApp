using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using theBakeShopApi.Models;
using theBakeShopApi.Services;

namespace theBakeShopApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductInfoRepository _productInfoRepository;
        private readonly IMapper _mapper;

        public ProductsController(ILogger<ProductsController> logger,
            IProductInfoRepository productInfoRepository,
            IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInfoRepository = productInfoRepository ?? throw new ArgumentNullException(nameof(productInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var productEntities = await _productInfoRepository.GetProductsAsync();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productEntities));
        }



    }
}
