using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

[ApiController]
[Route("companies")]
public class CompaniesController : ControllerBase
{
    private readonly DbSet<CompanyEntity> _dbSet;
    
    public CompaniesController(DbContext context)
    {
        _dbSet = context.Set<CompanyEntity>();
    }
    
    [HttpGet]
    public IActionResult GetCompanyById([FromQuery]int id)
    {
        var result = _dbSet.Find(id);

        return Ok(result);
    }

    [HttpPost]
    public IActionResult CreateCompany([FromBody] CompanyEntity entity)
    {
        _dbSet.Add(entity);

        return Created();
    }
    
    [HttpPut]
    public IActionResult UpdateCompany([FromBody] CompanyEntity entity)
    {
        _dbSet.Update(entity);

        return Accepted();
    }
    
    [HttpDelete]
    public IActionResult DeleteCompanyById(int id)
    {
        var result = _dbSet.Find(id);
        _dbSet.Remove(result!);

        return NoContent();
    }
}