using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiVersoning.Api;

namespace WebApiVersoning.Api.Controllers
{
    [ApiController]
    [ApiVersion(ApiVersions.V1)]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "This is version 1" });
        }
    }

}

namespace MyApp.Controllers.V2
{
    [ApiVersion(ApiVersions.V2)]
    [ApiController]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion(ApiVersions.V2)]
        public IActionResult GetV2()
        {
            return Ok(new { Message = "This is version 2" });
        }
    }
}

