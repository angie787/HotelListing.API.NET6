using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals resort and spa",
                    Address = "Negril",
                    CountryId = 1,
                    Raring = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort suites",
                    Address = "George Town",
                    CountryId = 3,
                    Raring = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    Raring = 4
                });
        }
    }
}
