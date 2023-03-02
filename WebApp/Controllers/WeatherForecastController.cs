using Microsoft.AspNetCore.Mvc;
using WebApp.ControllerClasses;
using WebApp.Controllers.MyWeatherServices;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IMyWeatherServices myServices;
        private readonly ILogger<WeatherForecastController> mylogger;

        public WeatherForecastController(IMyWeatherServices myServices, ILogger<WeatherForecastController> logger)
        {
            this.myServices = myServices;
            mylogger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return myServices.WeatherData();
        }
    }
}