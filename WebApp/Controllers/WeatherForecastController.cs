using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherService weatherService;

        public WeatherForecastController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

    [HttpGet(Name = "GetWeatherForecast")]

        public IEnumerable<WeatherForecast> Get()
        {
            return weatherService.WeatherData();
        }
    }
}