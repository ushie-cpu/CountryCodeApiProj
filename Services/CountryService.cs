using AutoMapper;
using Data;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using Services.Extensions;

namespace Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CountryService(IRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Result> FindAsync(GetCountryDto request)
        {
            var countryCode = request.PhoneNumber.GetCountryCode();
            var country = await Task.Run(() => repository.FindAsync(a => a.CountryCode.Equals(countryCode))
                .Include(a => a.CountryDetail) 
                .FirstOrDefault());

            if (country == null)
            {
                return null!;
            }

            return new Result
            {
                PhoneNumber = request.PhoneNumber,
                Country = mapper.Map<CountryDto>(country)
            };    
        }
    }
}
