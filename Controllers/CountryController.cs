using country_api.Models;
using country_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace country_api.Controllers
{
    /// <summary>
    /// Country API Routes
    /// </summary>
    [Produces("application/json")]
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

        /// <summary>
        /// Return a list of countries
        /// </summary>
        [HttpGet]
        // Returns a list of all the country
        public ActionResult<List<Country>> Get() =>
            _countryService.Get();

        /// <summary>
        /// Return a country from the ID
        /// </summary>
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

        /// <summary>
        /// Create a new country
        /// </summary>
        [HttpPost]
        public ActionResult<Country> Create(Country country)
        {
            _countryService.Create(country);

            return CreatedAtRoute("GetCountry", new { id = country.Id.ToString() }, country);
        }

        /// <summary>
        /// Edit an existing country by ID
        /// </summary>
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

        /// <summary>
        /// Delete a country by ID
        /// </summary>
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