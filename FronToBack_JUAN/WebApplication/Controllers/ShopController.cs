using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
