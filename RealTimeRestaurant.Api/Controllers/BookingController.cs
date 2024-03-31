﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealTimeRestaurant.BusinessLayer.Abstract;
using RealTimeRestaurant.DtoLayer.BookingDto;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var value = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            _bookingService.TAdd(new Booking()
            {
                Name = createBookingDto.Name,
                Mail = createBookingDto.Mail,
                Phone = createBookingDto.Phone,
                Date = createBookingDto.Date,
                PersonCount = createBookingDto.PersonCount
            });

            return Ok("Kategori Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            _bookingService.TUpdate(new Booking()
            {
                BookingId = updateBookingDto.BookingId,
                Name = updateBookingDto.Name,
                Mail = updateBookingDto.Mail,
                Phone = updateBookingDto.Phone,
                Date = updateBookingDto.Date,
                PersonCount = updateBookingDto.PersonCount
            });

            return Ok("Kategori Güncellendi");
        }
    }
}
