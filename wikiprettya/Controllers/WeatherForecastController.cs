using Microsoft.AspNetCore.Mvc;
using wikiprettya.Models;
using System.Collections.Generic ; 
using Microsoft.EntityFrameworkCore ;
// using wikiprettya.Data ; 
// using System.Data.Entity;

namespace wikiprettya.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly dbContext _context; 

    public WeatherForecastController(ILogger<WeatherForecastController> logger, dbContext context)
    {
        _logger = logger;
        _context = context ;  
    }

    [HttpGet]
    public  IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
