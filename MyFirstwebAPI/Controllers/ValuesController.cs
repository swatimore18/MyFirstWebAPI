using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstwebAPI.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route ("api/[controller]")]
        public IActionResult Get() 
        {
            return Ok(new { message = "Hello from Azure-ready API" });
        }
    }
}
