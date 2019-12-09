using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Paxi.DataFlow.Domain.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paxi.DataFlow.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IProcessDomain _processDomain;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProcessDomain processDomain)
        {
            _logger = logger;
            _processDomain = processDomain;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var xxx = await _processDomain.RunProcess(Guid.NewGuid(), Guid.NewGuid(), null);
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
