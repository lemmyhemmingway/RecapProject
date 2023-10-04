using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : Controller
{
    private readonly ICarService _carService;

    // GET
    public CarsController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var result = _carService.GetAll();
        if (result.Success) return Ok(result.Data);

        return BadRequest(result.Message);
    }

    [HttpPost]
    public IActionResult Post(Car car)
    {
        var result = _carService.Add(car);
        if (result.Success) return Ok(result.Message);

        return BadRequest(result.Message);
    }
    
    [HttpGet("brand")]
    public IActionResult GetByBrandId(int id)
    {
        var result = _carService.GetByBrandId(id);
        if (result.Success) return Ok(result.Data);

        return BadRequest(result.Message);
    }
    
    [HttpGet("color")]
    public IActionResult GetByColorId(int id)
    {
        var result = _carService.GetByColorId(id);
        if (result.Success) return Ok(result.Data);

        return BadRequest(result.Message);
    }
}