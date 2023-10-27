using KrustyKrab.Data;
using KrustyKrab.Models;
using Microsoft.AspNetCore.Mvc;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SizesController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;

    public SizesController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var sizes = _dbContext.Sizes
            .Where(s => !s.IsDeleted);
        return Ok(sizes);
    }

    [HttpPost]
    public IActionResult Post(Size size)
    {
        _dbContext.Sizes.Add(size);
        _dbContext.SaveChanges();
        return Created($"/api/sizes/{size.Id}", size);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var foundSize = _dbContext.Sizes
            .SingleOrDefault(d => d.Id == id);
        if (foundSize == null) return NotFound("Could not find a size with specified id");
        foundSize.IsDeleted = true;
        _dbContext.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    public IActionResult Put(Size size)
    {
        var foundSize = _dbContext.Sizes.SingleOrDefault(d => d.Id == size.Id);
        if (foundSize == null) return NotFound();
        foundSize.Name = size.Name;
        foundSize.Price = size.Price;
        foundSize.ShortHand = size.ShortHand;
        _dbContext.SaveChanges();
        return Ok(size);
    }
};