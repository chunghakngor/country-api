namespace country_api.Models
{
    public class CountryDatabaseSettings: ICountryDatabaseSettings
    {  
        public string CountryCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ICountryDatabaseSettings
    {
        string CountryCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}