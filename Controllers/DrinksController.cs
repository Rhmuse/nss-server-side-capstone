using KrustyKrab.Data;
using Microsoft.AspNetCore.Mvc;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DrinksController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;

    public DrinksController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var drinks = _dbContext.Drinks.OrderBy(d => d.Name);
        return Ok(drinks);
    }
}