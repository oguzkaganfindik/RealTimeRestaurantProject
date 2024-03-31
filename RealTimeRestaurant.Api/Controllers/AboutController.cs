﻿using Microsoft.AspNetCore.Mvc;
using RealTimeRestaurant.BusinessLayer.Abstract;
using RealTimeRestaurant.DtoLayer.AboutDto;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl
            };

            _aboutService.TAdd(about);
            return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id) 
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda alanı silindi");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutId = updateAboutDto.AboutId,
                Title = updateAboutDto.Title,
                ImageUrl = updateAboutDto.ImageUrl,
                Description = updateAboutDto.Description
            };
            
            _aboutService.TUpdate(about);
            return Ok("Hakkımda Alanı Güncellendi");
        }

        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);

        }
    }
}
