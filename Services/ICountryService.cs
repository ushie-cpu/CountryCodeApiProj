using Entity.DTOs;

namespace Services
{
    public interface ICountryService
    {
        Task<Result> FindAsync(GetCountryDto request);
    }
}
