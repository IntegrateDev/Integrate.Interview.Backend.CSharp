using Microsoft.AspNetCore.Mvc;

namespace Integrate.Interview.Backend.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "This is a sample response" });
        }
    }
}
