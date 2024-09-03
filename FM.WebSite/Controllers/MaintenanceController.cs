using Microsoft.AspNetCore.Mvc;
using FM.WebSite.Models;

namespace FM.WebSite.Controllers
{
    public class MaintenanceController : Controller
    {
        public IActionResult MaintenanceHome()
        {
            return View();
        }
        public IActionResult Visits()
        {
            return View();
        }
        public IActionResult Fridges()
        {
            return View();
        }
        public IActionResult CreateFault() 
        {
            return View();
        }
        public IActionResult Reports() 
        {
            return View();
        }
        public IActionResult ScheduleVisit()
        {
            return View();
        }
        public IActionResult ViewVisits() 
        {
            return View();
        }
        public IActionResult Logout() 
        {
            return View();
        }
    }
}
