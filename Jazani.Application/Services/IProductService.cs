using Jazani.Application.Dtos.Products;

namespace Jazani.Application.Services;

public interface IProductService
{
    Task<IReadOnlyList<ProductMediumDto>> FindAllAsync();
    Task<ProductDto> FindByIdAsync(int id);
}