using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstApi.Entities;
using MyFirstApi.Services;

namespace MyFirstApi.Controllers;

[ApiController]
[Route("companies")]
public class CompaniesController : ControllerBase
{
    private readonly IFilmService _service;
    
    public CompaniesController(IFilmService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult GetCompanyById([FromQuery]int id)
    {
        var result = _service.GetById(id);

        return Ok(result);
    }
}