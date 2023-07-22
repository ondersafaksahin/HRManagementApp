using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HRManagementApp.Presentation.Areas.Manager.Controllers
{
    public class ManagerController : Controller
    {
        [Area("Manager")]
        [Authorize(Roles = "Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
