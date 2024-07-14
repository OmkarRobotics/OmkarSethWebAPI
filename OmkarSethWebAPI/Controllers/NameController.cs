using Microsoft.AspNetCore.Mvc;

namespace OmkarSethWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet(Name = "GetName")]
        public IActionResult Get()
        {
            var name = new { Name = "Omkar Seth" };
            return Ok(name);
        }
    }
}
