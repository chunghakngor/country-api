using country_api.Models;
using country_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace country_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryService _countryService;

        public CountryController(CountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public ActionResult<List<Country>> Get() =>
            _countryService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCountry")]
        public ActionResult<Country> Get(string id)
        {
            var country = _countryService.Get(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        [HttpPost]
        public ActionResult<Country> Create(Country country)
        {
            _countryService.Create(country);

            return CreatedAtRoute("GetCountry", new { id = country.Id.ToString() }, country);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Country countryIn)
        {
            var country = _countryService.Get(id);

            if (country == null)
            {
                return NotFound();
            }

            _countryService.Update(id, countryIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var country = _countryService.Get(id);

            if (country == null)
            {
                return NotFound();
            }

            _countryService.Remove(country.Id);

            return NoContent();
        }
    }
}