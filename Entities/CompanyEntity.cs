namespace MyFirstApi.Entities;

public class CompanyEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<FilmEntity> Films { get; set; } 
}