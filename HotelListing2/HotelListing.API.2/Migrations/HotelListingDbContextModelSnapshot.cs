// <auto-generated />
using HotelListing.API._2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListing.API._2.Migrations
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

            modelBuilder.Entity("HotelListing.API._2.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "India",
                            ShortName = "IN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pakistan",
                            ShortName = "PK"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bangladesh",
                            ShortName = "BD"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Indoneshia",
                            ShortName = "ID"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Shri Lanka",
                            ShortName = "SL"
                        });
                });

            modelBuilder.Entity("HotelListing.API._2.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Mumbai",
                            CountryId = 1,
                            Name = "Taj Hotel",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Mumbai",
                            CountryId = 1,
                            Name = "Oberoy Hotel",
                            Rating = 4.9000000000000004
                        },
                        new
                        {
                            Id = 3,
                            Address = "Pune",
                            CountryId = 2,
                            Name = "Shinde Hotel",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 4,
                            Address = "Nagpur",
                            CountryId = 1,
                            Name = "PNR Hotel",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 5,
                            Address = "Amravati",
                            CountryId = 3,
                            Name = "Bose Hotel",
                            Rating = 4.5
                        });
                });

            modelBuilder.Entity("HotelListing.API._2.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.API._2.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListing.API._2.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
