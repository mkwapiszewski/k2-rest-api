using Test.Domain.Models.Product;

namespace Test.Services
{
    public interface IProductsService
    {
        CreateProductResponse PostProduct(CreateProductRequest product);
        IEnumerable<GetProductsResponse> GetProducts();
    }
}
