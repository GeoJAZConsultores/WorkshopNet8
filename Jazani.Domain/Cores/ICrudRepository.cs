namespace Jazani.Domain.Cores;

public interface ICrudRepository<TEntity,  TId>
{
    Task<IReadOnlyList<TEntity>> FindAllAsync();
    
    Task<TEntity?> FindByIdAsync(TId id);
}