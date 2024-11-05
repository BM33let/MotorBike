using AutoMapper;
using DIRTBIKESBM.Dto;
using DIRTBIKESBM.Interfaces;
using DIRTBIKESBM.Models;
using DIRTBIKESBM.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DIRTBIKESBM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryContoller : Controller 
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryContoller(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IActionResult GetCategories()
        {
            var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(categories);
        }
        [HttpGet("{categoryId}")]
        [ProducesResponseType(200, Type = typeof(Category))]
        [ProducesResponseType(400)]
        public IActionResult GetCategory(int categoryId)
        {
            if (!_categoryRepository.CategoryExists(categoryId))
                return NotFound();

            var category = _mapper.Map<CategoryDto>(_categoryRepository.GetCategory(categoryId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(category);
        }
        [HttpGet("motor/{categoryId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Motor>))]
        [ProducesResponseType(400)]
        public IActionResult GetMotorByCategoryId(int categoryId)
        {
            var motors = _mapper.Map<List<MotorDto>>(
                _categoryRepository.GetMotorByCategory(categoryId));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(motors);
        }
    }
}
