using System.ComponentModel.DataAnnotations;

namespace Entity.DTOs
{
    public record GetCountryDto
    {
        [Required,Phone]
        public string PhoneNumber { get; init; } = string.Empty;
    }

    public record Result
    {
        public string? PhoneNumber { get; set; }
        public CountryDto? Country { get; set; }
    }

    public record CountryDto
    {
        public string? CountryCode { get; set; }
        public string? Name { get; set; }
        public string? CountryIso { get; set; }
        public ICollection<CountryDetailsDto>? CountryDetails { get; set; }
    }

    public record CountryDetailsDto
    {
        public string? Operator { get; set; }
        public string? OperatorCode { get; set; }
    }
}
