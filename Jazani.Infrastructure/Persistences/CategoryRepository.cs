using Jazani.Domain.Models;
using Jazani.Domain.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Jazani.Infrastructure.Cores.Persistences;

namespace Jazani.Infrastructure.Persistences;

public class CategoryRepository : CrudRepository<Category, int>, ICategoryRepository
{
    public CategoryRepository(InfrastructureDbContext context) : base(context)
    {
    }
}