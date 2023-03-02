using WebApp.Models;

namespace WebApp.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> WeatherData();
    }
}
