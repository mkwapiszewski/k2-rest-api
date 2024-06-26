using Test.Domain.Models.Order;
using Test.Domain.Models.Product;

namespace Test.Services
{
    public interface IOrdersService
    {
        CreateOrderResponse PostOrder(CreateOrderRequest product);
    }
}
