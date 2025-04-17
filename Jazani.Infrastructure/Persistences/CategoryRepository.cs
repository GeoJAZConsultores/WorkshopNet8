using Jazani.Domain.Models;
using Jazani.Domain.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Persistences;

public class CategoryRepository : ICategoryRepository
{
    private readonly InfrastructureDbContext _context;
    
    public CategoryRepository(InfrastructureDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Category>> FindAllAsync()
    {
        var categories = await _context.Categories.ToListAsync();

        return categories;
    }

    public async Task<Category?> FindByIdAsync(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        
        return category;
    }
}