using Microsoft.AspNetCore.Mvc;

namespace Gateway.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "GatewayController", "Gateway"
        };

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Gateway> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Gateway
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
