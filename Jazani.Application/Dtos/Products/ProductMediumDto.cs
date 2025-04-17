using Jazani.Application.Dtos.Categories;

namespace Jazani.Application.Dtos.Products;

public class ProductMediumDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    
    public virtual CategorySmallDto? Category { get; set; }
}