using Microsoft.AspNetCore.Mvc;

namespace WorkforceScheduler.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "🚀 Welcome to Workforce Scheduler";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
