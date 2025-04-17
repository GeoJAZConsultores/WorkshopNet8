using Jazani.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Jazani.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productRepository.FindAllAsync();
        
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var product = await _productRepository.FindByIdAsync(id);
        
        return product == null ? NotFound() : Ok(product);
    }
    
}