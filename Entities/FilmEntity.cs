namespace MyFirstApi.Entities;

public class FilmEntity
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int CompanyId { get; set; }
    
    public CompanyEntity Company { get; set; }
    
    public List<ActorFilmEntity> ActorFilms { get; set; }
}