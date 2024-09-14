using AutoMapper;
using MyFirstApi.DataAccess;
using MyFirstApi.Entities;
using MyFirstApi.Entities.Models;

namespace MyFirstApi.Services;

public class FilmService : IFilmService
{
    private readonly IFilmRepo _repo;
    private readonly IMapper _mapper;
    
    public FilmService(IFilmRepo repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public FilmModel GetById(int id)
    {
        var entity = _repo.GetById(id);

        var reesult = _mapper.Map<FilmEntity, FilmModel>(entity);

        return reesult;

    }
}