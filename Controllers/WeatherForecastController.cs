using Microsoft.AspNetCore.Mvc;
using TrelloBackend.Models;

namespace TrelloBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
      /*  List<User> users = new List<User>
        {
            new (1, "admin", "qwerty"),
            new (2, "tim", "tim"),
            new (3, "user", "password")
        };


        [HttpPost]
        async Task Post(HttpResponse response, HttpRequest request)
        {
            bool otvet = false;
            try
            {
                var usera = await request.ReadFromJsonAsync<User>();
                if (usera != null)
                {
                    foreach (var user in users)
                    {
                        if (user.Name == usera.Name & user.password == usera.password)
                        {
                            otvet = !otvet;
                            break;
                        }
                    }
                    await response.WriteAsJsonAsync(otvet);
                }
                else
                {
                    throw new Exception("Некорректные данные");
                }
            }
            catch (Exception)
            {
                response.StatusCode = 400;
                await response.WriteAsJsonAsync(new { message = "Некорректные данные" });
            }
        }*/

    }
}
