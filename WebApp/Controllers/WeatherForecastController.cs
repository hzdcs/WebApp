using Microsoft.AspNetCore.Mvc;
using WebApp.ControllerClasses;
using WebApp.Controllers.MyWeatherServices;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IMyWeatherServices myService;
        private readonly ILogger<WeatherForecastController> mylogger;


        public WeatherForecastController(IMyWeatherServices myService, ILogger<WeatherForecastController> logger)
        {
            this.myService = myService;
            mylogger = logger;    
        }

    [HttpGet(Name = "GetWeatherForecast")]

        public IEnumerable<WeatherForecast> Get()
        {
            return myService.WeatherData();
        }
    }
}