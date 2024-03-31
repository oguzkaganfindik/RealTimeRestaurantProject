using AutoMapper;
using RealTimeRestaurant.DtoLayer.AboutDto;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.Api.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
