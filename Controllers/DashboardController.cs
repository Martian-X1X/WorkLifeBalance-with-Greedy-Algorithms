using Microsoft.AspNetCore.Mvc;
using WorkforceScheduler.Models;
using WorkforceScheduler.Repositories.Interfaces; // Interfaces only
using System.Threading.Tasks;

namespace WorkforceScheduler.Controllers
{
    public class DashboardController : Controller
{
    private readonly IEmployeeRepository _employeeRepo;
    private readonly IShiftRepository _shiftRepo;

    public DashboardController(IEmployeeRepository employeeRepo, IShiftRepository shiftRepo)
    {
        _employeeRepo = employeeRepo;
        _shiftRepo = shiftRepo;
    }

    public async Task<IActionResult> Index()
{
    var employees = await _employeeRepo.GetAllAsync() ?? Enumerable.Empty<Employee>();
    var shifts = await _shiftRepo.GetAllAsync() ?? Enumerable.Empty<Shifts>();

    ViewBag.Employees = employees;
    ViewBag.Shifts = shifts;

    return View();
}



       [HttpPost]
[ValidateAntiForgeryToken]  // Add for security
public async Task<IActionResult> AddEmployee(Employee employee)
{
    if (ModelState.IsValid)
    {
        await _employeeRepo.AddAsync(employee);
        return RedirectToAction("Index");
    }
    // Repopulate on error
    var employees = await _employeeRepo.GetAllAsync();
    var shifts = await _shiftRepo.GetAllAsync();
    ViewBag.Employees = employees;
    ViewBag.Shifts = shifts;
    return View("Index");
}

[HttpPost]
[ValidateAntiForgeryToken]  // Add for security
public async Task<IActionResult> AddShift(Shifts shift)
{
    if (ModelState.IsValid)
    {
        await _shiftRepo.AddAsync(shift);
        return RedirectToAction("Index");
    }
    // Repopulate on error
    var employees = await _employeeRepo.GetAllAsync();
    var shifts = await _shiftRepo.GetAllAsync();
    ViewBag.Employees = employees;
    ViewBag.Shifts = shifts;
    // Optional: Add to TempData for user message
    TempData["Error"] = "Please fix the errors below.";
    return View("Index");
}
    }
}