using Jazani.Domain.Models;

namespace Jazani.Domain.Repositories;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> FindAllAsync();
    
    Task<Product?> FindByIdAsync(int id);
}