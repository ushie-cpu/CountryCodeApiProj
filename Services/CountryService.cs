using AutoMapper;
using Data;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;

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
            var country = await repository.FindAsync(a => a.CountryCode.Equals(1))
                .Include(a => a.CountryDetail) 
                .FirstOrDefaultAsync();

            var data = mapper.Map<Result>(country); 
            data.PhoneNumber = request.PhoneNumber; 
            return data;    
        }
    }
}
