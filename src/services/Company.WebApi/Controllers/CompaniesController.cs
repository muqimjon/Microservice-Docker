using Microsoft.AspNetCore.Mvc;

namespace Company.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "CompaniesController", "Company"
        };

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Company> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Company
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
