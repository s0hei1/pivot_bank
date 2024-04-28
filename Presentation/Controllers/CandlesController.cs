using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models.Outputs;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CandlesController : Controller
{
    
    [HttpGet("/GetCandles")]
    public async Task<IActionResult> GetCandles()
    {
        return null;
    }
    
}