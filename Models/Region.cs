namespace country_api.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public City[] Cities { get; set; }
        public double Population { get; set; }
        public double Area { get; set; }
    }
}