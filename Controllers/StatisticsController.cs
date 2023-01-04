using Microsoft.AspNetCore.Mvc;
using TwitterStatistics.Models;

namespace TwitterStatistics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticsController : ControllerBase
    {
      
        private readonly ILogger<StatisticsController> _logger;

        public StatisticsController(ILogger<StatisticsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetStatistics")]
        public IEnumerable<TweetSpec> Get()
        {
            // Call Service -> Repository
            return new List<TweetSpec>() { new TweetSpec(DateTime.Now, 1, new List<string>() { "Sample A", "Sample B" }) };
        }
    }
}
