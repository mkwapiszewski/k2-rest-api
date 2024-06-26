using AutoMapper;
using AutoMapper.QueryableExtensions;
using Test.Domain.Models.Product;
using Test.Persistence;
using Test.Persistence.Models;

namespace Test.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductsService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            if (!_context.Products.Any())
            {
                _context.Products.AddRange(
                    new tProduct() { Name = "Product1", Price = 10.5m },
                    new tProduct() { Name = "Product2", Price = 20m }
                );
                _context.SaveChanges();
            }
        }
        public CreateProductResponse PostProduct(CreateProductRequest product)
        {
            var productEntity = _mapper.Map<tProduct>(product);
            _context.Products.Add(productEntity);
            _context.SaveChanges();
            

            return _mapper.Map<CreateProductResponse>(productEntity);
        }

        public IEnumerable<GetProductsResponse> GetProducts()
        {
            return _mapper.Map<IEnumerable<GetProductsResponse>>(_context.Products);
        }
    }
}
