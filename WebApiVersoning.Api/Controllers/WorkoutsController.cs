using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Data;
using WebApiVersoning.Api;

namespace WebApiVersioning.Api.Controllers
{
    [ApiVersion(ApiVersions.V1)]
    [ApiVersion(ApiVersions.V2)]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class WorkoutsController : ControllerBase
    {
        [MapToApiVersion(ApiVersions.V1)]
        [HttpGet("{workoutId}")]
        public IActionResult GetWorkoutV1(string workoutId)
        {
            return Ok(new { WorkoutId = workoutId, Version = ApiVersions.V1 });
        }

        [MapToApiVersion(ApiVersions.V2)]
        [HttpGet("{workoutId}")]
        public IActionResult GetWorkoutV2(string workoutId)
        {
            return Ok(new { WorkoutId = workoutId, Version = ApiVersions.V2 });
        }
    }

}
