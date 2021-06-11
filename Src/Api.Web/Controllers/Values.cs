using System.Linq;
using System.Threading.Tasks;
using Api.Infrastructure.SqlContext;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Values : Controller
    {
        private readonly ILogger<Values> _logger;
        private readonly Context _context;
        public Values(ILogger<Values> logger, Context context)
        {
            _context = context;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("User is open Api"); 
            var vs = _context.Tags.ToList();
            return Ok(vs);
        }
    }
}
