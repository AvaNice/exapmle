using MyFirstApi.Entities;

namespace MyFirstApi.DataAccess;

public interface IFilmRepo
{
    FilmEntity GetById(int id);
}