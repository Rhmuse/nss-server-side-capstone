using KrustyKrab.Data;
using Microsoft.AspNetCore.Mvc;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SidesController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;

    public SidesController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var sides = _dbContext.Sides
        .Where(s => !s.IsDeleted)
        .OrderBy(s => s.Name);
        return Ok(sides);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var foundSide = _dbContext.Sides
            .SingleOrDefault(d => d.Id == id);
        if (foundSide == null) return NotFound("Could not find a drink with specified id");
        foundSide.IsDeleted = true;
        _dbContext.SaveChanges();
        return NoContent();
    }
}