using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using QueryViewer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryViewer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueryController : ControllerBase
    {
        private readonly ILogger<QueryController> Logger;
        private readonly DatabaseQuery DatabaseQuery;

        public QueryController(ILogger<QueryController> logger, DatabaseQuery databaseQuery)
        {
            Logger = logger;
            DatabaseQuery = databaseQuery;
        }

        [HttpGet]
        public IEnumerable<string> GetQueries()
        {
            return DatabaseQuery.GetQueriesNames();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetQueryResultById(int id)
        {
            try
            {
                (string[] headers, IEnumerable<object> rows) = await DatabaseQuery.GetQueryResult(id);
                return new JsonResult(new { headers, rows });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
