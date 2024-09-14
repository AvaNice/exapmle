using AutoMapper;
using MyFirstApi.Entities;
using MyFirstApi.Entities.Models;

namespace MyFirstApi.Mapping;

public class FirstApiMappingProfile : Profile
{
    public FirstApiMappingProfile()
    {
        CreateMap<FilmModel, FilmEntity>().ReverseMap();
        CreateMap<CompanyModel, CompanyEntity>().ReverseMap();
    }
}