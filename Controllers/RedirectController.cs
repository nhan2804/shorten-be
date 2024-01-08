using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationX.Data;
using WebApplicationX.Models;

namespace WebApplicationX.Controllers
{
    [ApiController]
    [Route("r")]
    public class RedirectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<RedirectController> _logger;

        public RedirectController(ILogger<RedirectController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //[HttpGet("{code}")]
        //public async ActionResult Redirect(string code)
        //{
        //    var entity = await _context.Shortens.FirstOrDefaultAsync(s => s.CodeLink == code);

        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    // You can perform additional logic here if needed.

        //    return Redirect(entity.OriginalLink);
        //}
    }
}
