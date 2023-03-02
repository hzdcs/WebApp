using WebApp.ControllerClasses;

namespace WebApp.Controllers.MyWeatherServices
{
    public interface IMyWeatherServices
    {
        string[] getSummaries();

        int getLenght();

        IEnumerable<WeatherForecast> WeatherData();
    }
}
