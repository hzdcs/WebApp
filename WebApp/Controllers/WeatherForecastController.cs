using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IMyService myService;
        public WeatherForecastController(IMyService myService, ILogger<WeatherForecastController> logger)
        {
            this.myService = myService;
            _logger = logger;
        }

        private readonly ILogger<WeatherForecastController> _logger;

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = myService.getSummaries()[Random.Shared.Next(myService.getSummaries().Length)]
            })
            .ToArray();
        }
    }
}