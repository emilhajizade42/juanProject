using Microsoft.EntityFrameworkCore;

namespace WebApplication.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
    }
}
