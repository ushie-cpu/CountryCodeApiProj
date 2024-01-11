using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    public class CountryDetail
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        [Required]
        public string? Operator { get; set; }
        [Required]  
        public string? OperatorCode { get; set; }
    }
}
