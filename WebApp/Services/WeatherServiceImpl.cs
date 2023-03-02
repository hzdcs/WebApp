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
                Summary = summaryService.getSummaries()[Random.Shared.Next(summaryService.getLength())]
            })
            .ToArray();
        }

    }
}
