using Microsoft.AspNetCore.Mvc;
using Test.Domain.Models.Product;
using Test.Services;

namespace Test.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductsService _productsService;

    public ProductsController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<GetProductsResponse>> GetProducts()
    {
        return _productsService.GetProducts().ToList();
    }

    [HttpPost]
    public ActionResult<CreateProductResponse> PostProduct(CreateProductRequest product)
    {
        var result = _productsService.PostProduct(product);
        return CreatedAtAction(nameof(PostProduct), new { id = result.Id }, result);
    }
}