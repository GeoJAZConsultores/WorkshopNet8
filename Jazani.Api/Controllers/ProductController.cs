using Jazani.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jazani.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productService.FindAllAsync();

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var product = await _productService.FindByIdAsync(id);

        return Ok(product);
    }
}