using AutoMapper;
using Jazani.Domain.Models;

namespace Jazani.Application.Dtos.Products.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductMediumDto>();

        CreateMap<Product, ProductBodyDto>().ReverseMap();

    }
}