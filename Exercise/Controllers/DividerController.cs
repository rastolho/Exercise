using System;
using System.Collections.Generic;
using System.Linq;
using Exercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DividerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DividerController> _logger;
        private readonly IDividerService _dividerPoco;

        public DividerController(ILogger<DividerController> logger, IDividerService dividerPoco)
        {
            _logger = logger;
            _dividerPoco = dividerPoco;
        }

        [HttpGet]
        public IEnumerable<DividerNumber> GetDivider([FromQuery] List<int> numbers)
        {
            return _dividerPoco.GetDividerNumbers(numbers);
        }
    }
}
