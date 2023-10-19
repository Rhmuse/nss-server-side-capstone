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


}