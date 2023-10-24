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
            .Where(b => b.OrderId == null)
            .ToList();
        return Ok(burgers);
    }
}