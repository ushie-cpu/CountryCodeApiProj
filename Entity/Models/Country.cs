using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public int CountryCode { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? CountryIso { get; set; }
        public ICollection<CountryDetail> CountryDetail { get; set; } = new List<CountryDetail>();  
    }
}
