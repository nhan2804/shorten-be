using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Quartz;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplicationX.Data;

namespace WebApplicationX.Jobs
{
    public class CheckLink : IJob
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CheckLink> _logger;

        public CheckLink(ILogger<CheckLink> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            // Write your custom code here
            var links = await _context.Shortens.ToListAsync();
            _logger.LogInformation("Run");
            foreach (var link in links)
            {
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        var response = await httpClient.GetAsync(link.OriginalLink);
                        _logger.LogInformation(link.OriginalLink + " : "+response.StatusCode.ToString());
                        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            // Update the link status to "404" in the database
                            link.Status = 404;
                            _context.Update(link);
                            await _context.SaveChangesAsync();

                            _logger.LogInformation($"Link {link.OriginalLink} returned status 404. Link status updated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Error checking link {link.OriginalLink}: {ex.Message}");
                    }
                }
            }

            // You can return a Task.FromResult(true), but it's not necessary for a void method.
        }
    }
}
