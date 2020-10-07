
namespace country_api.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public double Population { get; set; }
        public float GDP { get; set; }

    }
}