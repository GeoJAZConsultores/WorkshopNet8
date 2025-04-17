using Jazani.Domain.Models;
using Jazani.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Jazani.Infrastructure.Cores.Contexts;

public class InfrastructureDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    
    public InfrastructureDbContext( IConfiguration configuration)
    {
        _configuration = configuration;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }
    
    
    
    #region DbSets
    public DbSet<Category> Categories { get; set; }
    #endregion
}