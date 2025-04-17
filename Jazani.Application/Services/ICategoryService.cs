using Jazani.Application.Dtos.Categories;

namespace Jazani.Application.Services;

public interface ICategoryService
{
    Task<IReadOnlyList<CategorySmallDto>> FindAllAsync();
    Task<CategoryDto> FindByIdAsync(int id);
    Task<CategorySmallDto> CreateAsync(CategoryBodyDto categoryBody);
    Task<CategorySmallDto> UpdateAsync(int id, CategoryBodyDto categoryBody);
}