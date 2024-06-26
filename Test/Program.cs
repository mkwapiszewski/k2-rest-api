using Microsoft.EntityFrameworkCore;
using Test.Domain.Extensions;
using Test.Persistence;
using Test.Persistence.Profiles;
using Test.Services;

var builder = WebApplication.CreateBuilder(args);

// Add DB context
builder.Services.AddDbContext<AppDbContext>(o => o.UseInMemoryDatabase("InMemoryDb"));

// Configure Dependency Injection

builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IOrdersService, OrdersService>();

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
        // Other JSON-specific settings
    });

// Register AutoMapper


builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.DocumentFilter<CustomSwaggerDocumentFilter>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger(opt => {opt.SerializeAsV2 = true; });
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
