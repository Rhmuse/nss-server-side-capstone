using KrustyKrab.Data;
using KrustyKrab.Models;
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

    [HttpPost]
    public IActionResult Post(NewBurgerDto burgerDto)
    {
        Burger burger = new Burger();
        burger.Name = burgerDto.Name;
        burger.Quantity = 1;
        _dbContext.Burgers.Add(burger);
        burgerDto.Toppings.ForEach(t =>
        {
            BurgerTopping burgerTopping = new BurgerTopping();
            burgerTopping.BurgerId = burger.Id;
            burgerTopping.ToppingId = t.ToppingId;
            if (t.Extra) burgerTopping.Extra = true;
            _dbContext.BurgerToppings.Add(burgerTopping);
        });
        _dbContext.SaveChanges();
        return Created($"/api/burgers/{burger.Id}", burger);
    }
}