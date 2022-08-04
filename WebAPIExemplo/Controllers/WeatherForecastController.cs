using Microsoft.AspNetCore.Mvc;
using WebAPIExemplo.Models;

namespace WebAPIExemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post(Weather wt)
        {
            return Ok();
        }
    }
}