using Jazani.Domain.Models;
using Jazani.Domain.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Persistences;

public class ProductRepository : IProductRepository
{
    private readonly InfrastructureDbContext _context;

    public ProductRepository(InfrastructureDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Product>> FindAllAsync()
    {
        return await _context.Products
            // .Include(x => x.Category)
            .ToListAsync();
    }

    public async Task<Product?> FindByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }
}
