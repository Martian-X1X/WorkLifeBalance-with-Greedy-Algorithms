using Microsoft.AspNetCore.Mvc;

namespace WorkforceScheduler.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Demo data – later we’ll pull from DB
            var employees = new List<dynamic>
            {
                new { Id = 1, Name = "Alice Johnson", Role = "Nurse", Shift = "Morning" },
                new { Id = 2, Name = "Bob Smith", Role = "Engineer", Shift = "Night" }
            };

            var shifts = new List<dynamic>
            {
                new { Id = 1, Name = "Morning", Start = "08:00", End = "16:00" },
                new { Id = 2, Name = "Night", Start = "16:00", End = "00:00" }
            };

            ViewBag.Employees = employees;
            ViewBag.Shifts = shifts;

            return View();
        }
    }
}
