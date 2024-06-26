using Microsoft.AspNetCore.Mvc;
using Test.Domain.Models.Common;
using Test.Domain.Models.Order;
using Test.Services;

namespace Test.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrdersService _ordersService;

    public OrdersController(IOrdersService ordersService)
    {
        _ordersService = ordersService;
    }

    [HttpPost]
    public ActionResult<CreateOrderResponse> PostOrderQueryParams(string name, K2Collection orderList)
    {
        var orders = orderList.GetListValues();
        var result = _ordersService.PostOrder(null);
        
        return CreatedAtAction(nameof(PostOrderQueryParams), new { result.Id }, result );
    }

    [HttpPost]
    public ActionResult<CreateOrderResponse> PostOrderObjectParam(CreateOrderRequest product)
    {
        var orders = product.OrderListParsed.GetListValues();
        var result = _ordersService.PostOrder(null);

        return CreatedAtAction(nameof(PostOrderObjectParam), new { result?.Id }, result );
    }
}