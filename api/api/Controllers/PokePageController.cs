using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokePageController : ControllerBase
    {
        [HttpGet(Name = "GetStatus")]
        public IActionResult Get()
        {
            return Ok(new { message = "API da PokePage no ar" });
        }
    }
}
