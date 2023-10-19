using KrustyKrab.Data;
using Microsoft.AspNetCore.Mvc;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CombosController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;

    public CombosController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var combos = _dbContext.Combos;
        return Ok(combos);
    }
}