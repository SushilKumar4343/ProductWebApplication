using Microsoft.EntityFrameworkCore;
using ProductWebApplication.Models;

namespace ProductWebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
    }
}
