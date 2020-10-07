using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace country_api.Models
{
    public class Country
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CountryCode { get; set; }
        
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public double Population { get; set; }
        public double GDP { get; set; }

    }
}