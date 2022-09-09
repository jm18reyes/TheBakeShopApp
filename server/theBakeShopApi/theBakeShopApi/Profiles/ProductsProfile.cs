using AutoMapper;

namespace theBakeShopApi.Profiles
{
    public class ProductsProfile: Profile
    {

        public ProductsProfile()
        {
            CreateMap<Entities.Product, Models.ProductDto>();
        }
    }
}
