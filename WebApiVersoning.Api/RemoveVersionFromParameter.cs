using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
// Add the following helper classes for Swagger to understand API versioning
public class RemoveVersionFromParameter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        var versionParameter = operation.Parameters.SingleOrDefault(p => p.Name == "version");
        if (versionParameter != null)
        {
            operation.Parameters.Remove(versionParameter);
        }
    }
}
