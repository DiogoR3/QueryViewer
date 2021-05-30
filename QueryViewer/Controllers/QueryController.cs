using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace QueryViewer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueryController : ControllerBase
    {
        private readonly ILogger<QueryController> Logger;
        private readonly Configuration Configuration;

        public QueryController(ILogger<QueryController> logger, IOptions<Configuration> configuration)
        {
            Logger = logger;
            Configuration = configuration.Value;
        }

        [HttpGet]
        public Configuration GetQueries()
        {
            return Configuration;
        }
    }
}
