using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HRManagementApp.Presentation.Areas.Employee.Controllers
{
    public class EmployeeController : Controller
    {
        [Area("Employee")]
        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
