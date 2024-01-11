using Data.Configuration;
using Entity.Models;

namespace Data
{
    public class AppDBContext
    {
        public ICollection<Country> Countries { get; set; } = Database.Country();
        public ICollection<CountryDetail> CountryDetails { get; set; } = Database.CountryDetails();

        public AppDBContext(){}

        public IQueryable<Country> Set() =>
            (from country in Countries
             select new Country
             {
                 Id = country.Id,
                 Name = country.Name,
                 CountryCode = country.CountryCode,
                 CountryIso = country.CountryIso,
                 CountryDetail = CountryDetails.Where(d => d.CountryId == country.Id).ToList(),
             }).AsQueryable();
    }

}
