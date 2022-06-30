using AutoMapper;
using HotelListing.API._2.Data;
using HotelListing.API._2.Models.Country;
using HotelListing.API._2.Models.Hotel;

namespace HotelListing.API._2.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
