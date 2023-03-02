using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApp.ControllerClasses;

namespace WebApp.Controllers.MyWeatherServices
{
    public class MyTempServiceImpl : IMyWeatherServices
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// Wettertestdaten werden zufällig erzeugt.
        /// </summary>
        /// <returns>Array mit den Wettertestdaten (Datum, Temperatur, Zusammenfassung) wird zurückgegeben.</returns>
        public IEnumerable<WeatherForecast> WeatherData()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = getSummaries()[Random.Shared.Next(getLenght())]
            })
            .ToArray();
        }

        public string[] getSummaries()
        {
            return Summaries;
        }

        public int getLenght()
        {
            return Summaries.Length;
        }
    }
}
