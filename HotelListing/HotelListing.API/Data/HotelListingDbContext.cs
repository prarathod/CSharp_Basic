using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }    
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="India",
                    SortName="IN"
                },new Country
                {
                Id = 2,
                    Name = "BanglaDesh",
                    SortName = "BD"
                },
                new Country
                {
                    Id = 3,
                    Name = "Pakistan",
                    SortName = "PK"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name="RamLal Hotel",
                    Address="XYZ post amravati",
                    Ratings=4.5,
                    CountryId=1
                }, new Hotel
                {
                    Id = 2,
                    Name = "Sham Lal Hotel",
                    Address = "ABC post amravati",
                    Ratings = 5,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Soromani Hotel",
                    Address = "farshi stop post amravati",
                    Ratings = 5,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Sita Hotel",
                    Address = "XYZ post amravati",
                    Ratings = 4.5,
                    CountryId = 1
                }
                );

        }


    }
}
