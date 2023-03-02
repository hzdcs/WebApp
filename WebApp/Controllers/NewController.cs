using Microsoft.AspNetCore.Mvc;
using WebApp.ControllerClasses;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Hallo", "Tschau"
    };
        private readonly ILogger<NewController> _logger;

        public NewController(ILogger<NewController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetNewController")]
        public IEnumerable<NewControllerClass> Get()
        {
            return Enumerable.Range(1, 2).Select(index => new NewControllerClass
            {
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}