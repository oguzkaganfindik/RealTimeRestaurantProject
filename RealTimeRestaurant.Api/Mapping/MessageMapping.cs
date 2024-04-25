﻿using AutoMapper;
using RealTimeRestaurant.DtoLayer.MessageDto;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.Api.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<Slider, ResultMessageDto>().ReverseMap();
            CreateMap<Slider, CreateMessageDto>().ReverseMap();
            CreateMap<Slider, UpdateMessageDto>().ReverseMap();
        }
    }
}
