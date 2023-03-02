namespace WebApp
{
    public class MyServiceImpl : IMyService
    {
        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string[] getSummaries()
        {
            return Summaries;
        }
    }
}
