using KrustyKrab.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BurgersController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;

    public BurgersController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var burgers = _dbContext.Burgers
            .Include(b => b.BurgerToppings)
            .ThenInclude(bt => bt.Topping)
            .Where(b => b.OrderId == null && !b.IsDeleted)
            .ToList();
        return Ok(burgers);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var foundBurger = _dbContext.Burgers
            .SingleOrDefault(d => d.Id == id);
        if (foundBurger == null) return NotFound("Could not find a drink with specified id");
        foundBurger.IsDeleted = true;
        _dbContext.SaveChanges();
        return NoContent();
    }
}