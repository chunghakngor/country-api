using country_api.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace country_api.Services
{
    public class CountryService
    {
        private readonly IMongoCollection<Country> _Countries;

        public CountryService(ICountryDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _Countries = database.GetCollection<Country>(settings.CountryCollectionName);
        }

        public List<Country> Get() =>
            _Countries.Find(Country => true).ToList();

        public Country Get(string id) =>
            _Countries.Find<Country>(Country => Country.Id == id).FirstOrDefault();

        public Country Create(Country Country)
        {
            _Countries.InsertOne(Country);
            return Country;
        }

        public void Update(string id, Country CountryIn) =>
            _Countries.ReplaceOne(Country => Country.Id == id, CountryIn);

        public void Remove(Country CountryIn) =>
            _Countries.DeleteOne(Country => Country.Id == CountryIn.Id);

        public void Remove(string id) => 
            _Countries.DeleteOne(Country => Country.Id == id);
    }
}