// <auto-generated />
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListing.API.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    partial class HotelListingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "India",
                            SortName = "IN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BanglaDesh",
                            SortName = "BD"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pakistan",
                            SortName = "PK"
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ratings")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "XYZ post amravati",
                            CountryId = 1,
                            Name = "RamLal Hotel",
                            Ratings = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "ABC post amravati",
                            CountryId = 2,
                            Name = "Sham Lal Hotel",
                            Ratings = 5.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "farshi stop post amravati",
                            CountryId = 3,
                            Name = "Soromani Hotel",
                            Ratings = 5.0
                        },
                        new
                        {
                            Id = 4,
                            Address = "XYZ post amravati",
                            CountryId = 1,
                            Name = "Sita Hotel",
                            Ratings = 4.5
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.API.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
