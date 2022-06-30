using Microsoft.EntityFrameworkCore;

namespace HotelListing.API._2.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        // Seeding Data In Tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="India",
                    ShortName="IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "Pakistan",
                    ShortName = "PK"
                },
                new Country
                {
                    Id = 3,
                    Name = "Bangladesh",
                    ShortName = "BD"
                },
                new Country
                {
                    Id = 4,
                    Name = "Indoneshia",
                    ShortName = "ID"
                },
                new Country
                {
                    Id = 5,
                    Name = "Shri Lanka",
                    ShortName = "SL"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj Hotel",
                    Address="Mumbai",
                    CountryId = 1,
                    Rating =5
                    
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Oberoy Hotel",
                    Address = "Mumbai",
                    CountryId = 1,
                    Rating = 4.9
                    
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Shinde Hotel",
                    Address = "Pune",
                    Rating = 4,
                    CountryId=2
                },
                new Hotel
                {
                    Id = 4,
                    Name = "PNR Hotel",
                    Address = "Nagpur",
                    Rating = 5,
                    CountryId=1

                },
                new Hotel
                {
                    Id = 5,
                    Name = "Bose Hotel",
                    Address = "Amravati",
                    Rating = 4.5,
                    CountryId=3
                }
                );
        }
    }
}
