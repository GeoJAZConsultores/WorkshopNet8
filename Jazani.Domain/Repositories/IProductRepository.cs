using Jazani.Domain.Cores;
using Jazani.Domain.Models;

namespace Jazani.Domain.Repositories;

public interface IProductRepository : ICrudRepository<Product, int>
{
    
}