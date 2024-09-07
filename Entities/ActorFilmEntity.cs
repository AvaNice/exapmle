namespace MyFirstApi.Entities;

public class ActorFilmEntity
{
    public int ActorId { get; set; }
    
    public ActorEntity Actor { get; set; }
    public int FilmId { get; set; }
    
    public FilmEntity Film { get; set; }
}