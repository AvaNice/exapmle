using MyFirstApi.Entities.Models;

namespace MyFirstApi.Services;

public interface IFilmService
{
    FilmModel GetById(int id);
}