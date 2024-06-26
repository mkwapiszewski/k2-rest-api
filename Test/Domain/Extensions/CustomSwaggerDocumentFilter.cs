using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Test.Domain.Extensions
{
    public class CustomSwaggerDocumentFilter : IDocumentFilter
    {
        private readonly IConfiguration _configuration;

        public CustomSwaggerDocumentFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var host = _configuration["SwaggerSettings:Host"];
            swaggerDoc.Extensions.Add("host", new OpenApiString(host));
            swaggerDoc.Extensions.Add("basePath", new OpenApiString(""));
            var schemesArray = new OpenApiArray
        {
            new OpenApiString("http")
        };
            swaggerDoc.Extensions.Add("schemes", schemesArray);
        }
    }
}
