using Jazani.Domain.Models;
using Jazani.Domain.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Jazani.Infrastructure.Cores.Persistences;

namespace Jazani.Infrastructure.Persistences;

public class ProductRepository : CrudRepository<Product, int>, IProductRepository
{
    public ProductRepository(InfrastructureDbContext context) : base(context)
    {
    }

}
