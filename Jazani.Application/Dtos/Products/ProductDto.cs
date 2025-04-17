using Jazani.Application.Dtos.Categories;

namespace Jazani.Application.Dtos.Products;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Status { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    
    public virtual CategorySmallDto? Category { get; set; }
}