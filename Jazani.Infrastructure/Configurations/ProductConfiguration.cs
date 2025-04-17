using Jazani.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jazani.Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Name)
			.HasColumnName("name")
			.IsRequired()
			.HasMaxLength(300);
        builder.Property(x => x.Description).HasColumnName("description");
        builder.Property(x => x.Price).HasColumnName("price");
        builder.Property(x => x.Stock).HasColumnName("stock");
        builder.Property(x => x.CategoryId).HasColumnName("category_id");
        builder.Property(x => x.Status).HasColumnName("state");
        builder.Property(x => x.CreatedAt).HasColumnName("created_at");
        builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");

        builder.HasOne(x => x.Category)
	        .WithMany(x => x.Products)
	        .HasForeignKey(x => x.CategoryId);

    }
}