using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class CountryData : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(new Country
            {
                Id = 1,
                Name = "Nigeria",  
                CountryCode = 234,
                CountryIso = "NG",
                CountryDetail = new List<CountryDetail>
                {
                    new CountryDetail
                    {
                        Id = 1,
                        Operator = "MTN Nigeria",
                        OperatorCode = "MTN NG",
                        CountryId = 1,
                    },
                    new CountryDetail
                    {
                        Id = 2,
                        Operator = "Airtel Nigeria",
                        OperatorCode = "ANG",
                        CountryId = 1,
                    },
                    new CountryDetail
                    {
                        Id = 3,
                        Operator = "9 Mobile Nigeria",
                        OperatorCode = "ETN",
                        CountryId = 1,
                    },
                    new CountryDetail
                    {
                        Id = 4,
                        Operator = "Globacom Nigeria",
                        OperatorCode = "GLO NG",
                        CountryId = 1,
                    }
                }
            }, new Country
            {
                Id = 2,
                Name = "Ghana",
                CountryCode = 233,
                CountryIso = "GH",
                CountryDetail = new List<CountryDetail>
                {
                    new CountryDetail
                    {
                        Id = 5,
                        Operator = "Vodafone Ghana",
                        OperatorCode = "Vodafone GH",
                        CountryId = 2,
                    },
                    new CountryDetail
                    {
                        Id = 6,
                        Operator = "MTN Ghana",
                        OperatorCode = "MTN Ghana",
                        CountryId = 2,
                    },
                    new CountryDetail
                    {
                        Id = 7,
                        Operator = "Tigo Ghana",
                        OperatorCode = "Tigo Ghana",
                        CountryId = 2,
                    }
                }
            }, new Country
            {
                Id = 3,
                Name = "Benin Republic",
                CountryCode = 229,
                CountryIso = "BN",
                CountryDetail = new List<CountryDetail>
                {
                    new CountryDetail
                    {
                        Id = 8,
                        Operator = "MTN Benin",
                        OperatorCode = "MTN Benin",
                        CountryId = 3,
                    },
                    new CountryDetail
                    {
                        Id = 9,
                        Operator = "Moov Benin",
                        OperatorCode = "Moov Benin",
                        CountryId = 3,
                    }
                }
            },
            new Country
            {
                Id = 4,
                Name = "Côte d'Ivoire ",
                CountryCode = 225,
                CountryIso = "CIV",
                CountryDetail = new List<CountryDetail>
                {
                    new CountryDetail
                    {
                        Id = 10,
                        Operator = "MTN Côte d'Ivoire",
                        OperatorCode = "MTN CIV",
                        CountryId = 4,
                    }
                }
            });
        }
    }
}
