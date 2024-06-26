using AutoMapper;
using Test.Domain.Models.Product;
using Test.Persistence.Models;

namespace Test.Persistence.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateProductRequest, tProduct>();
            CreateMap<tProduct, CreateProductResponse>();

            CreateMap<tProduct, GetProductsResponse>();
        }
    }
}
