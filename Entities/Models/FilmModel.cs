namespace MyFirstApi.Entities.Models;

public class FilmModel
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int CompanyId { get; set; }
    
    public CompanyModel Company { get; set; }
}