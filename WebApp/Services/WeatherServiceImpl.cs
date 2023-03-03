using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApp.Interfaces;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Services
{
    public class WeatherServiceImpl : IWeatherService
    {
        private ISummaryService summaryService;
        public WeatherServiceImpl(ISummaryService summaryService)
        {
            this.summaryService = summaryService;
        }

        IEnumerable<WeatherForecast> IWeatherService.WeatherData => getWeatherData();

        /// <summary>
        /// Wettertestdaten werden zufällig erzeugt.
        /// </summary>
        /// <returns>Array mit den Wettertestdaten (Datum, Temperatur, Zusammenfassung) wird zurückgegeben.</returns>
        private IEnumerable<WeatherForecast> getWeatherData()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaryService.Summaries[Random.Shared.Next(summaryService.Length)]
            })
            .ToArray();
        }

    }
}
