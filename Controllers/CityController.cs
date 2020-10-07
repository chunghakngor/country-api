using Microsoft.AspNetCore.Mvc;

namespace country_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetCity(){
            return Ok();
        }

        
    }
}