using AutoMapper;
using Entity.DTOs;
using Entity.Models;

namespace CountryCodeApiProj.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CountryDetail, CountryDetailsDto>();
            CreateMap<Country, CountryDto>()
                .ForMember(dest => dest.CountryDetails, opt => opt.MapFrom(src => src.CountryDetail));     
        }
    }
}
