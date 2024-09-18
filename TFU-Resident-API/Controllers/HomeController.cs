using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TFU_Resident_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Sep490");
        }
    }
}
