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
        var combos = _dbContext.Combos
            .Where(c => !c.IsDeleted);
        return Ok(combos);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var foundCombo = _dbContext.Combos
            .SingleOrDefault(d => d.Id == id);
        if (foundCombo == null) return NotFound("Could not find a drink with specified id");
        foundCombo.IsDeleted = true;
        _dbContext.SaveChanges();
        return NoContent();
    }
}