using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace country_api.Models
{
    public class Country
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary> The International Country Code of the Country </summary>
        [Required]        
        public string CountryCode { get; set; }
        
        /// <summary> The Name of the Country </summary>
        [BsonElement("Name")]
        [Required]
        public string Name { get; set; }

        /// <summary> The Nationality of the Country </summary>
        public string Nationality { get; set; }

        /// <summary> The Current Capital of the Country </summary>
        [Required]
        public string Capital { get; set; }
        /// <summary> The Area Capital of the Country in KM </summary>
        public double Area { get; set; }
        /// <summary> The Area Capital of the Country in Millions </summary>
        public double Population { get; set; }
        /// <summary> The Area Capital of the Country in Billions </summary>
        public double GDP { get; set; }

    }
}