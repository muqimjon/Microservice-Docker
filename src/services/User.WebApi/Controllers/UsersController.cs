using Microsoft.AspNetCore.Mvc;

namespace User.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "UsersController", "User"
        };

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<User> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
