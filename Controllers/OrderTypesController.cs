using KrustyKrab.Data;
using Microsoft.AspNetCore.Mvc;

namespace KrustyKrab.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderTypesController : ControllerBase
{
    private KrustyKrabDbContext _dbContext;
    public OrderTypesController(KrustyKrabDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var orderTypes = _dbContext.OrderTypes;
        return Ok(orderTypes);
    }
}