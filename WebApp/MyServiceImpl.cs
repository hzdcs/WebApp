using System;
using WebApp.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp
{
    public class MyServiceImpl : IMyService
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
