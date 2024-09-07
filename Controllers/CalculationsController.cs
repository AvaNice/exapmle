using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Services;

namespace MyFirstApi.Controllers;

[ApiController]
[Route("calculations")]
public class CalculationsController : ControllerBase
{
    private readonly CalculationService _service;
    
    public CalculationsController()
    {
        _service = new CalculationService();
    }
    
    [HttpPost("{first}/sum")]
    public IActionResult Sum(
        [FromRoute] int first,
        [FromBody] object second)
    {
       // var result = _service.Sum(first, second);
        
        return Ok($"sult");
    }
}