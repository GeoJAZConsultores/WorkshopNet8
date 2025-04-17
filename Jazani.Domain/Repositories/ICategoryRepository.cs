using Jazani.Domain.Models;

namespace Jazani.Domain.Repositories;

public interface ICategoryRepository
{
    Task<IReadOnlyList<Category>> FindAllAsync();
    
    Task<Category?> FindByIdAsync(int id);
}