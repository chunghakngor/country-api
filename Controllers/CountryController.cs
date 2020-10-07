using country_api.Models;
using country_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace country_api.Controllers
{
    [Route("api/[controller]")]
    // Sets the route for the controller host:<port>/api/Country
    [ApiController]
    public class CountryController : ControllerBase 
    {
        // Calling the database connection service
        private readonly CountryService _countryService;

        public CountryController(CountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        // Returns a list of all the country
        public ActionResult<List<Country>> Get() =>
            _countryService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCountry")]
        // Return a country from the Id
        public ActionResult<Country> Get(string id)
        {
            // find the country in the database using the ID
            var country = _countryService.Get(id);
            // if it doesn't exist then return not found
            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        [HttpPost]
        // POST route for a new country
        public ActionResult<Country> Create(Country country)
        {
            _countryService.Create(country);

            return CreatedAtRoute("GetCountry", new { id = country.Id.ToString() }, country);
        }

        [HttpPut("{id:length(24)}")]
        // PUT Route for an existing country (requires the country ID)
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
        // DEL Route from using country Id
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