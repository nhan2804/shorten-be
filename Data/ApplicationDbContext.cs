using Microsoft.EntityFrameworkCore;
using WebApplicationX.Models;
namespace WebApplicationX.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Shorten> Shortens { get; set; }
    }
}
