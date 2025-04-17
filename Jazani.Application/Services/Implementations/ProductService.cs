using System.Linq.Expressions;
using AutoMapper;
using Jazani.Application.Dtos.Products;
using Jazani.Domain.Models;
using Jazani.Domain.Repositories;

namespace Jazani.Application.Services.Implementations;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(
        IProductRepository productRepository,
        IMapper mapper
    )
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<ProductMediumDto>> FindAllAsync()
    {
        Expression<Func<Product, bool>> predicate = x => x.Status == "A";

        var includes = new List<Expression<Func<Product, object>>>()
        {
            x => x.Category
        };


        var products = await _productRepository.FindAllAsync(
            predicate: predicate,
            includes: includes
        );

        return _mapper.Map<IReadOnlyList<ProductMediumDto>>(products);
    }

    public async Task<ProductDto> FindByIdAsync(int id)
    {
        Expression<Func<Product, bool>> predicate = x => x.Id == id;

        var includes = new List<Expression<Func<Product, object>>>()
        {
            x => x.Category
        };

        var product = await _productRepository.FindFirstOrDefaultAsync(
            predicate: predicate,
            includes: includes
        );


        if (product is null) throw new Exception("Product not found");

        return _mapper.Map<ProductDto>(product);
    }
}