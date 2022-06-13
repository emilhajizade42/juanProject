using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategory{ get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Sliders> Sliders { get; set; }

    }
}
