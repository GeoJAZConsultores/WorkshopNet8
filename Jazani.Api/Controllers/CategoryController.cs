using Jazani.Application.Dtos.Categories;
using Jazani.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jazani.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.FindAllAsync();
            
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.FindByIdAsync(id);
            
            return Ok(category);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryBodyDto categoryBody)
        {
            var category = await _categoryService.CreateAsync(categoryBody);
            
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CategoryBodyDto categoryBody)
        {
            var category = await _categoryService.UpdateAsync(id, categoryBody);
            
            return Ok(category);
        }

    }
}
