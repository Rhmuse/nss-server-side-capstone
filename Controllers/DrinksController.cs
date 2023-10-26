using KrustyKrab.Data;
using KrustyKrab.Models;
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
        var drinks = _dbContext.Drinks
            .OrderBy(d => d.Name)
            .Where(d => !d.IsDeleted);
        return Ok(drinks);
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var foundDrink = _dbContext.Drinks
            .SingleOrDefault(d => d.Id == id);
        if (foundDrink == null) return NotFound("Could not find a drink with specified id");
        return Ok(foundDrink);
    }

    [HttpPost]
    public IActionResult Post(Drink drink)
    {
        _dbContext.Drinks.Add(drink);
        _dbContext.SaveChanges();
        return Created($"/api/drinks/{drink.Id}", drink);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var foundDrink = _dbContext.Drinks
            .SingleOrDefault(d => d.Id == id);
        if (foundDrink == null) return NotFound("Could not find a drink with specified id");
        foundDrink.IsDeleted = true;
        _dbContext.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    public IActionResult Put(Drink drink)
    {
        var foundDrink = _dbContext.Drinks.SingleOrDefault(d => d.Id == drink.Id);
        if (foundDrink == null) return NotFound();
        foundDrink.Name = drink.Name;
        foundDrink.Price = drink.Price;
        _dbContext.SaveChanges();
        return Ok(drink);
    }
}