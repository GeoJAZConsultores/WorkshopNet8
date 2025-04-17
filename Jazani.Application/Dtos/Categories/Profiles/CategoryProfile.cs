using AutoMapper;
using Jazani.Domain.Models;

namespace Jazani.Application.Dtos.Categories.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategorySmallDto>();
        CreateMap<Category, CategoryDto>();

        // CreateMap<CategoryBodyDto, Category>();
        CreateMap<Category, CategoryBodyDto>().ReverseMap();
    }
}