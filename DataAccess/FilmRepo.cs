using Microsoft.EntityFrameworkCore;
using MyFirstApi.Entities;

namespace MyFirstApi.DataAccess;

public class FilmRepo : IFilmRepo
{
    private readonly DbSet<FilmEntity> _dbSet;
    
    public FilmRepo(DbContext context)
    {
        _dbSet = context.Set<FilmEntity>();
    }

    public FilmEntity GetById(int id)
    {
        var result = _dbSet.Find(id);

        return result;
    }
}