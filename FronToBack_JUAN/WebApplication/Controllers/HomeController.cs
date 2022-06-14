using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DAL;
using WebApplication.Models;
using WebApplication.ViewModel.HomeViewModel;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
         private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel()
            {
                Sliders = _context.Sliders.ToList(),
                Blogs = _context.Blogs.ToList(),
                Features = _context.Features.ToList(),
            };
            return View(home);
        }
    }
}
