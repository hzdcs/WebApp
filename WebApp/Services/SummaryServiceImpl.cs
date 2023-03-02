using System;
using WebApp.Interfaces;

namespace WebApp.Services
{
    public class SummaryServiceImpl : ISummaryService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        #region Methoden
        public string[] getSummaries()
        {
            return Summaries;
        }

        public int getLength()
        {
            return Summaries.Length;
        }
        #endregion
    }
}
