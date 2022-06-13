using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        DbSet<Blogs> Blogs { get; set; }
        DbSet<Brands> Brands { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Colors> Colors { get; set; }
        DbSet<Features> Features { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductCategory> ProductCategory{ get; set; }
        DbSet<ProductColors> ProductColors { get; set; }
        DbSet<ProductImages> ProductImages { get; set; }
        DbSet<Settings> Settings { get; set; }
        DbSet<Sliders> Sliders { get; set; }

    }
}
