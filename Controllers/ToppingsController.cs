using KrustyKrab.Data;
using KrustyKrab.Models;
using Microsoft.AspNetCore.Mvc;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToppingsController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;

    public ToppingsController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var toppings = _dbContext.Toppings
            .OrderBy(d => d.Name);
        return Ok(toppings);
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var foundTopping = _dbContext.Toppings
            .SingleOrDefault(d => d.Id == id);
        if (foundTopping == null) return NotFound("Could not find a topping with specified id");
        return Ok(foundTopping);
    }

    [HttpPost]
    public IActionResult Post(Topping topping)
    {
        _dbContext.Toppings.Add(topping);
        _dbContext.SaveChanges();
        return Created($"/api/toppings/{topping.Id}", topping);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var foundTopping = _dbContext.Toppings
            .SingleOrDefault(d => d.Id == id);
        if (foundTopping == null) return NotFound("Could not find a topping with specified id");
        foundTopping.IsDeleted = true;
        _dbContext.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    public IActionResult Put(Topping topping)
    {
        var foundTopping = _dbContext.Toppings.SingleOrDefault(d => d.Id == topping.Id);
        if (foundTopping == null) return NotFound();
        foundTopping.Name = topping.Name;
        foundTopping.Price = topping.Price;
        _dbContext.SaveChanges();
        return Ok(topping);
    }
}