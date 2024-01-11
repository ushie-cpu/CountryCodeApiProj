using AutoMapper;
using Entity.DTOs;
using Entity.Models;

namespace CountryCodeApiProj.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Country, Result>();     
        }
    }
}
