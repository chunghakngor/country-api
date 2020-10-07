using Microsoft.EntityFrameworkCore;
namespace country_api.Models
{
    public class CountryContext: DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options): base(options){ 

        }

        public DbSet<Country> Country { get; set; }
    }
}