using Microsoft.AspNetCore.Mvc;

namespace Car.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "CarsController", "CarsController"
        };

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Car> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Car
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
