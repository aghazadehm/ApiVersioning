using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApiVersoning.Api.Controllers
{
    [ApiVersion(ApiVersions.V1)]
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        private static readonly string[] value = ["John", "Mary", "David"];

        [MapToApiVersion(ApiVersions.V1)]
        [HttpGet]
        public IActionResult ALLNames()
        {
            return Ok(value);
        }

    }
}
