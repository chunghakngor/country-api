using Microsoft.AspNetCore.Mvc;
namespace country_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        
        [HttpGet("{CountryCode}")]
        public IActionResult GetCountry(){ 
            return Ok();
        }

        [HttpPost]
        public IActionResult PostCountry(){
            return Ok();
        }
    }
}