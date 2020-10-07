namespace country_api.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public double Population { get; set; }
        public double Area { get; set; }
    
    }
}