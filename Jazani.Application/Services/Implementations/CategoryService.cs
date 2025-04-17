using AutoMapper;
using Jazani.Application.Dtos.Categories;
using Jazani.Domain.Models;
using Jazani.Domain.Repositories;

namespace Jazani.Application.Services.Implementations;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(
        ICategoryRepository categoryRepository,
        IMapper mapper
    )
    {
        this._categoryRepository = categoryRepository;
        this._mapper = mapper;
    }


    public async Task<IReadOnlyList<CategorySmallDto>> FindAllAsync()
    {
        var categories = await _categoryRepository.FindAllAsync();

        return _mapper.Map<IReadOnlyList<CategorySmallDto>>(categories);
    }

    public async Task<CategoryDto> FindByIdAsync(int id)
    {
        var category = await _categoryRepository.FindByIdAsync(id);

        if (category is null) throw new Exception("Category not found");

        return _mapper.Map<CategoryDto>(category);
    }

    public async Task<CategorySmallDto> CreateAsync(CategoryBodyDto categoryBody)
    {
        var category = _mapper.Map<Category>(categoryBody);

        category.CreatedAt = DateTime.UtcNow;
        category.Status = "A";

        await _categoryRepository.SaveAsync(category);

        return _mapper.Map<CategorySmallDto>(category);
    }

    public async Task<CategorySmallDto> UpdateAsync(int id, CategoryBodyDto categoryBody)
    {
        var category = await _categoryRepository.FindByIdAsync(id);

        if (category is null) throw new Exception("Category not found");

        _mapper.Map(categoryBody, category);
        category.UpdatedAt = DateTime.UtcNow;

        await _categoryRepository.SaveAsync(category);

        return _mapper.Map<CategorySmallDto>(category);
    }
}