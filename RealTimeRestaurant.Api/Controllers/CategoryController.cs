﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealTimeRestaurant.BusinessLayer.Abstract;
using RealTimeRestaurant.DtoLayer.CategoryDto;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList() 
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto) 
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = true
            });

            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id) 
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id) 
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                CategoryId = updateCategoryDto.CategoryId,
                Status = updateCategoryDto.Status
            });

            return Ok("Kategori Güncellendi");
        }
    }
}
