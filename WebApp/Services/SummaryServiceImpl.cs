using System;
using WebApp.Interfaces;

namespace WebApp.Services
{
    public class SummaryServiceImpl : ISummaryService
    {
        private static readonly string[] SummariesData = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        string[] ISummaryService.Summaries => SummariesData;

        public int Length => SummariesData.Length;
    }
}
